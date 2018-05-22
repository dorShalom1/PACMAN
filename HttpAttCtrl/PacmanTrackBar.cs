using PACMAN.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PACMAN
{
    class PacmanTrackBar : TrackBar
    {

        private Rectangle thumbRect;
        private Image _thumbImage = null;
        private Size _thumbSize = new Size(16, 16);

        public PacmanTrackBar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint"></see> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs"></see> that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawPacman(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.EnabledChanged"></see> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"></see> that contains the event data.</param>
        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.GotFocus"></see> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"></see> that contains the event data.</param>
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.LostFocus"></see> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"></see> that contains the event data.</param>
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            Invalidate();
        }

        private void DrawPacman(PaintEventArgs e)
        {
            try
            {
                //set up thumbRect approprietly
                if (Orientation == Orientation.Horizontal)
                {
                    #region horizontal
                    if (_thumbImage != null)
                    {
                        int TrackX = (((Value - Minimum) * (ClientRectangle.Width - _thumbImage.Width)) / (Maximum - Minimum));
                        thumbRect = new Rectangle(TrackX, ClientRectangle.Height / 2 - _thumbImage.Height / 2, _thumbImage.Width, _thumbImage.Height);
                    }
                    else
                    {
                        int TrackX = (((Value - Minimum) * (ClientRectangle.Width - _thumbSize.Width)) / (Maximum - Minimum));
                        thumbRect = new Rectangle(TrackX, ClientRectangle.Y + ClientRectangle.Height / 2 - _thumbSize.Height / 2, _thumbSize.Width, _thumbSize.Height);
                    }
                    #endregion
                }
                else
                {
                    #region vertical
                    if (_thumbImage != null)
                    {
                        int TrackY = (((Maximum - (Value)) * (ClientRectangle.Height - _thumbImage.Height)) / (Maximum - Minimum));
                        thumbRect = new Rectangle(ClientRectangle.Width / 2 - _thumbImage.Width / 2, TrackY, _thumbImage.Width, _thumbImage.Height);
                    }
                    else
                    {
                        int TrackY = (((Maximum - (Value)) * (ClientRectangle.Height - _thumbSize.Height)) / (Maximum - Minimum));
                        thumbRect = new Rectangle(ClientRectangle.X + ClientRectangle.Width / 2 - _thumbSize.Width / 2, TrackY, _thumbSize.Width, _thumbSize.Height);
                    }
                    #endregion
                }

                #region draw thumb

                //get thumb shape path 
                GraphicsPath thumbPath;
                if (_thumbCustomShape == null)
                    thumbPath = CreateRoundRectPath(thumbRect, _thumbRoundRectSize);
                else
                {
                    thumbPath = _thumbCustomShape;
                    Matrix m = new Matrix();
                    m.Translate(thumbRect.Left - thumbPath.GetBounds().Left, thumbRect.Top - thumbPath.GetBounds().Top);
                    thumbPath.Transform(m);
                }
                Pen thumbPen = new Pen(new Color());
                e.Graphics.DrawPath(thumbPen, thumbPath);
                
                #endregion draw thumb
            }
            catch (Exception ex)
            {

            }
        }

        private GraphicsPath _thumbCustomShape = null;
        /// <summary>
        /// Gets or sets the thumb custom shape. Use ThumbRect property to determine bounding rectangle.
        /// </summary>
        /// <value>The thumb custom shape. null means default shape</value>
        [Description("Set Slider's thumb's custom shape")]
        [Category("ColorSlider")]
        [Browsable(false)]
        [DefaultValue(typeof(GraphicsPath), "null")]
        public GraphicsPath ThumbCustomShape
        {
            get { return _thumbCustomShape; }
            set
            {
                _thumbCustomShape = value;
                //_thumbSize = (int) (_barOrientation == Orientation.Horizontal ? value.GetBounds().Width : value.GetBounds().Height) + 1;
                _thumbSize = new Size((int)value.GetBounds().Width, (int)value.GetBounds().Height);

                Invalidate();
            }
        }

        //private Image _thumbImage = Properties.Resources.BTN_Thumb_Blue;
        /// <summary>
        /// Gets or sets the Image used to render the thumb.
        /// </summary>
        /// <value>the thumb Image</value> 
        [Description("Set to use a specific Image for the thumb")]
        [Category("ColorSlider")]
        [DefaultValue(null)]
        public Image ThumbImage
        {
            get { return _thumbImage; }
            set
            {
                if (value != null)
                    _thumbImage = value;
                else
                    _thumbImage = null;
                Invalidate();
            }
        }

        private Size _thumbRoundRectSize = new Size(16, 16);
        /// <summary>
        /// Gets or sets the size of the thumb round rectangle edges.
        /// </summary>
        /// <value>The size of the thumb round rectangle edges.</value>
        [Description("Set Slider's thumb round rect size")]
        [Category("ColorSlider")]
        [DefaultValue(typeof(Size), "16; 16")]
        public Size ThumbRoundRectSize
        {
            get { return _thumbRoundRectSize; }
            set
            {
                int h = value.Height, w = value.Width;
                if (h <= 0) h = 1;
                if (w <= 0) w = 1;
                _thumbRoundRectSize = new Size(w, h);
                Invalidate();
            }
        }

        public static GraphicsPath CreateRoundRectPath(Rectangle rect, Size size)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(rect.Left + size.Width / 2, rect.Top, rect.Right - size.Width / 2, rect.Top);
            gp.AddArc(rect.Right - size.Width, rect.Top, size.Width, size.Height, 270, 90);

            gp.AddLine(rect.Right, rect.Top + size.Height / 2, rect.Right, rect.Bottom - size.Width / 2);
            gp.AddArc(rect.Right - size.Width, rect.Bottom - size.Height, size.Width, size.Height, 0, 90);

            gp.AddLine(rect.Right - size.Width / 2, rect.Bottom, rect.Left + size.Width / 2, rect.Bottom);
            gp.AddArc(rect.Left, rect.Bottom - size.Height, size.Width, size.Height, 90, 90);

            gp.AddLine(rect.Left, rect.Bottom - size.Height / 2, rect.Left, rect.Top + size.Height / 2);
            gp.AddArc(rect.Left, rect.Top, size.Width, size.Height, 180, 90);
            return gp;
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ColorSlider
            // 
            this.Size = new System.Drawing.Size(200, 48);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
