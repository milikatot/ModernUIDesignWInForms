using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace Gestionale.Controls;

public class PJButton : Button
{
	#region Fields
	private int borderSize = 0;
	private int borderRadius = 40;
	private Color borderColor = Color.PaleVioletRed;

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
    public int BorderRadius 
	{ 
		get => borderRadius; 
		set
		{
            borderRadius = value;
			this.Invalidate();
        }
	}

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
    public Color BackgroundColor 
	{ 
		get => BackColor; 
		set => BackColor = value; 
	}

    [Category("Pj Code Advance")]
    public Color TextColor
    {
        get => ForeColor;
        set => ForeColor = value;
    }
    #endregion

    #region Costructor
    public PJButton()
	{
		FlatStyle = FlatStyle.Flat;
		FlatAppearance.BorderSize = 0;
		Size = new(150, 40);
		BackColor = Color.MediumAquamarine;
		ForeColor = Color.White;
		Resize += new EventHandler(Button_Resize);
	}

	private void Button_Resize(object? sender, EventArgs e)
	{
		if (borderRadius > Height)
			BorderRadius = Height;
	}
	#endregion

	#region Methods
	private GraphicsPath GetFigurePath(RectangleF rect, float radius)
	{
		GraphicsPath path = new();
		path.StartFigure();
		path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
		path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
		path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
		path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
		path.CloseFigure();

		return path;
    }

	protected override void OnPaint(PaintEventArgs pevent)
	{
		base.OnPaint(pevent);
		pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

		RectangleF rectSurface = new(0, 0, Width, Height);
		RectangleF rectBorder = new(1, 1, Width - 0.8f, Height - 1);

		if (borderRadius > 2)
		{
			// rounded button
			using GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius);
			using GraphicsPath pathBorder = GetFigurePath(rectSurface, borderRadius - 1f);
			using Pen penSurface = new(Parent.BackColor, 2);
			using Pen penBorder = new(borderColor, borderSize);
			
			penBorder.Alignment = PenAlignment.Inset;
			Region = new(pathSurface);

			// draw border for HD result
			pevent.Graphics.DrawPath(penSurface, pathSurface);

			// button border
			if (borderSize >= 1)
				// draw control border
				pevent.Graphics.DrawPath(penBorder, pathBorder);
		}
		else
		{
			// normal button
			Region = new(rectSurface);
			if (borderSize >= 1)
			{
				using Pen penBorder = new(borderColor, borderSize);
				penBorder.Alignment = PenAlignment.Inset;
				pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);

            }

		}
    }


	protected override void OnHandleCreated(EventArgs e)
	{
		base.OnHandleCreated(e);
		Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
	}

	private void Container_BackColorChanged(object? sender, EventArgs e)
	{
		if (DesignMode)
			this.Invalidate();
	}
	#endregion
}
