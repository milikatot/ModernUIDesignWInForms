namespace Gestionale.Controls
{
    public partial class PJTextBox : UserControl
    {
        #region Fileds
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underLinedStyle = false;

        #endregion

        #region Properties
        public Color BorderColor 
        { 
            get => borderColor; 
            set 
            {
                borderColor = value;
                this.Invalidate();
            } 
        }
        public int BorderSize 
        { 
            get => borderSize; 
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        public bool UnderLinedStyle 
        { 
            get => underLinedStyle; 
            set 
            {
                underLinedStyle = value;
                this.Invalidate();
            } 
        }
        #endregion

        #region Costructor
        public PJTextBox()
        {
            InitializeComponent();
        }
        #endregion

        #region Ovveridden methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graps = e.Graphics;

            // draw border
            using Pen penBorder = new(borderColor, borderSize);

            penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

            if (underLinedStyle)
                graps.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
            else // normal style
                graps.DrawRectangle(penBorder, 0, 0, Width - 0.5f, Height - 0.5f);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(DesignMode)
                UpdateControlHeight();
            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        #endregion

        #region Private methods
        private void UpdateControlHeight()
        {
            if (!textBox1.Multiline)
            {
                int txtHeight = TextRenderer.MeasureText("Text", Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new(0, txtHeight);
                textBox1.Multiline = false;

                Height = textBox1.Height + Padding.Top + Padding.Bottom;
            }
        }
        #endregion
    }
}
