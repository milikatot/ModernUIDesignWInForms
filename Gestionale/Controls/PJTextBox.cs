using System.ComponentModel;

namespace Gestionale.Controls
{
    [DefaultEvent("_TextChanged")]
    public partial class PJTextBox : UserControl
    {
        #region Fileds
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underLinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;

        #endregion

        #region Properties

        [Category("Pj Code Advance")]
        public Color BorderColor 
        { 
            get => borderColor; 
            set 
            {
                borderColor = value;
                this.Invalidate();
            } 
        }

        [Category("Pj Code Advance")]
        public int BorderSize 
        { 
            get => borderSize; 
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Pj Code Advance")]
        public bool UnderLinedStyle 
        { 
            get => underLinedStyle; 
            set 
            {
                underLinedStyle = value;
                this.Invalidate();
            } 
        }

        [Category("Pj Code Advance")]
        public bool PasswordChar 
        { 
            get => textBox1.UseSystemPasswordChar; 
            set => textBox1.UseSystemPasswordChar = value; 
        }

        [Category("Pj Code Advance")]
        public bool Multiline 
        { 
            get => textBox1.Multiline; 
            set => textBox1.Multiline = value; 
        }

        [Category("Pj Code Advance")]
        public override Color BackColor 
        { 
            get => base.BackColor; 
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        [Category("Pj Code Advance")]
        public override Color ForeColor 
        { 
            get => base.ForeColor; 
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("Pj Code Advance")]
        public override Font Font 
        { 
            get => base.Font; 
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("Pj Code Advance")]
        public string Texts
        { 
            get => textBox1.Text; 
            set => textBox1.Text = value; 
        }

        [Category("Pj Code Advance")]
        public Color BorderFocusColor 
        { 
            get => borderFocusColor; 
            set => borderFocusColor = value; 
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

            if (isFocused)
                penBorder.Color = borderFocusColor;

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

        #region Events

        public event EventHandler _TextChanged;
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged is not null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }
    }
}
