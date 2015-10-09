using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Drawing;
using System.Drawing;
using MetroFramework;
using MetroFramework.Forms;
using System.Security;
using System.Drawing.Design;
using System.ComponentModel;

namespace SOAFramework.Client.Controls
{
    [Designer("SOAFramework.Client.Controls.TabPageCollectionEditor", typeof(UITypeEditor))]
    public class TabPageCollection : TabControl.TabPageCollection
    {
        public TabPageCollection(TabControl owner) : base(owner)
        { }
    }

    public delegate void TabControlCloseButtonClick(object sender, TabControlCloseButtonClickEventArgs e);

    [Designer("SOAFramework.Client.Controls.TabControlDesigner")]
    [ToolboxBitmap(typeof(TabControl))]
    public class TabControl : MetroTabControl
    {
        protected int hoveredIndex = -1;
        protected int hoveredCloseButtonIndex = -1;
        protected Dictionary<int, Rectangle> closeButtonDic = new Dictionary<int, Rectangle>();

        public TabControlCloseButtonClick CloseButtonClick { get; set; }

        protected override void DrawTabSelected(int index, Graphics graphics)
        {
            Color foreColor = MetroPaint.BackColor.Form(Theme);
            Color backColor = MetroPaint.GetStyleColor(Style);
            System.Windows.Forms.TabPage tabPage = TabPages[index];
            Rectangle tabRect = GetTabRect(index);
            using (Brush selectionBrush = new SolidBrush(MetroPaint.GetStyleColor(Style)))
            {
                Rectangle selectedTabRect = GetTabRect(index);
                Rectangle borderRectangle = new Rectangle(selectedTabRect.X + ((index == 0) ? 2 : 0), GetTabRect(index).Bottom + 2 - TabBottomBorderHeight, selectedTabRect.Width + ((index == 0) ? 0 : 2), TabBottomBorderHeight);
                graphics.FillRectangle(selectionBrush, borderRectangle);
            }

            if (index == 0)
            {
                tabRect.X = DisplayRectangle.X;
            }

            Rectangle bgRect = tabRect;

            tabRect.Width += 20;

            using (Brush bgBrush = new SolidBrush(backColor))
            {
                graphics.FillRectangle(bgBrush, bgRect);
            }

            TextRenderer.DrawText(graphics, tabPage.Text, MetroFonts.TabControl(FontSize, FontWeight),
                                  tabRect, foreColor, backColor, MetroPaint.GetTextFormatFlags(TextAlign));

            //画关闭按钮
            Color closeBackColor = backColor;
            Color closeForeColor = foreColor;
            if (hoveredCloseButtonIndex > -1 && hoveredCloseButtonIndex == index)
            {
                closeBackColor = SOAFramework.Client.Controls.Paint.Fade(closeBackColor);
            }

            Font buttonFont = new Font("Webdings", 6f);
            TextRenderer.DrawText(graphics, "r", buttonFont, closeButtonDic[index], closeForeColor, closeBackColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }

        protected virtual void DrawTabHovered(int index, Graphics graphics)
        {
            Color foreColor = MetroPaint.BackColor.Form(Theme);
            Color backColor = SOAFramework.Client.Controls.Paint.Fade(MetroPaint.GetStyleColor(Style));
            System.Windows.Forms.TabPage tabPage = TabPages[index];
            Rectangle tabRect = GetTabRect(index);
            using (Brush selectionBrush = new SolidBrush(MetroPaint.GetStyleColor(Style)))
            {
                Rectangle selectedTabRect = GetTabRect(index);
                Rectangle borderRectangle = new Rectangle(selectedTabRect.X + ((index == 0) ? 2 : 0), GetTabRect(index).Bottom + 2 - TabBottomBorderHeight, selectedTabRect.Width + ((index == 0) ? 0 : 2), TabBottomBorderHeight);
                graphics.FillRectangle(selectionBrush, borderRectangle);
            }

            if (index == 0)
            {
                tabRect.X = DisplayRectangle.X;
            }

            Rectangle bgRect = tabRect;

            tabRect.Width += 20;

            using (Brush bgBrush = new SolidBrush(backColor))
            {
                graphics.FillRectangle(bgBrush, bgRect);
            }

            TextRenderer.DrawText(graphics, tabPage.Text, MetroFonts.TabControl(FontSize, FontWeight),
                                  tabRect, foreColor, backColor, MetroPaint.GetTextFormatFlags(TextAlign));

            Color closeBackColor = backColor;
            Color closeForeColor = foreColor;
            if (hoveredCloseButtonIndex > -1 && hoveredCloseButtonIndex == index)
            {
                closeBackColor = SOAFramework.Client.Controls.Paint.Fade(backColor);
            }

            Font buttonFont = new Font("Webdings", 6f);
            TextRenderer.DrawText(graphics, "r", buttonFont, closeButtonDic[index], closeForeColor, closeBackColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
            closeButtonDic = new Dictionary<int, Rectangle>();
            for (var index = 0; index < TabPages.Count; index++)
            {
                int height = GetTabRect(index).Height - 10;
                int width = height;
                int y = GetTabRect(index).Height - height - 2;
                int x = this.GetTabRect(index).Right - width - 2;
                Rectangle buttonRec = new Rectangle(new Point(x, y), new Size(width, height));
                closeButtonDic[index] = buttonRec;
            }
        }

        protected override void OnPaintForeground(PaintEventArgs e)
        {
            for (var index = 0; index < TabPages.Count; index++)
            {
                if (index != SelectedIndex || index != hoveredIndex)
                {
                    DrawTab(index, e.Graphics);
                }
            }
            DrawTabBottomBorder(SelectedIndex, e.Graphics);
            if (SelectedIndex <= -1)
            {
                return;
            }

            base.DrawTab(SelectedIndex, e.Graphics);
            DrawTabSelected(SelectedIndex, e.Graphics);
            if (hoveredIndex > -1 && hoveredIndex != SelectedIndex)
            {
                DrawTabHovered(hoveredIndex, e.Graphics);
            }

            OnCustomPaintForeground(new MetroPaintEventArgs(Color.Empty, Color.Empty, e.Graphics));
        }


        protected override void DrawTabBottomBorder(int index, Graphics graphics)
        {
            using (Brush bgBrush = new SolidBrush(MetroPaint.GetStyleColor(Style)))
            {
                Rectangle borderRectangle = new Rectangle(DisplayRectangle.X, this.Bottom + 2 - TabBottomBorderHeight, DisplayRectangle.Width, TabBottomBorderHeight);
                if (index > -1)
                {
                    borderRectangle = new Rectangle(DisplayRectangle.X, GetTabRect(index).Bottom + 2 - TabBottomBorderHeight, DisplayRectangle.Width, TabBottomBorderHeight);
                }
                graphics.FillRectangle(bgBrush, borderRectangle);
            }
        }

       

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            Point mouse = Control.MousePosition;
            for (var i = 0; i < TabPages.Count; i++)
            {
                if (this.GetTabRect(i).Contains(this.PointToClient(mouse)))
                {
                    hoveredIndex = i;
                    if (closeButtonDic.ContainsKey(i) && closeButtonDic[i].Contains(this.PointToClient(mouse)))
                    {
                        hoveredCloseButtonIndex = i;
                    }
                    else
                    {
                        hoveredCloseButtonIndex = -1;
                    }
                    break;
                }
            }
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            hoveredIndex = -1;
            hoveredCloseButtonIndex = -1;
            base.OnMouseLeave(e);
        }

        [SecuritySafeCritical]
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            IntPtr hFont = MetroFonts.TabControl(FontSize, FontWeight).ToHfont();
            SendMessage(this.Handle, WM_SETFONT, hFont, (IntPtr)(-1));
            SendMessage(this.Handle, WM_FONTCHANGE, IntPtr.Zero, IntPtr.Zero);
            this.UpdateStyles();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            foreach (var key in closeButtonDic.Keys)
            {
                if (closeButtonDic[key].Contains(e.Location))
                {
                    TabControlCloseButtonClickEventArgs args = new TabControlCloseButtonClickEventArgs();
                    args.ClickIndex = key;
                    if (CloseButtonClick != null)
                    {
                        CloseButtonClick.Invoke(this, args);
                    }
                    break;
                }
            }
            base.OnMouseClick(e);
        }
    }

}
