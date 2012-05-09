using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Web.UI.HtmlControls;


namespace Evyatar.Web.Controls
{
    [ToolboxBitmap(typeof(Evyatar.Web.Controls.ScrollableListBox), "Evyatar.Web.Controls.ScrollableListBox.bmp")]
    public class ScrollableListBox : ListBox
    {
        #region Overridden LifeCycle

        #region OnInit
        /// <summary>
        /// Handles the <see cref="E:System.Web.UI.Control.Init"></see> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"></see> object that contains the event data.</param>
        protected override void OnInit(EventArgs e)
        {
            ClientScriptManager cs = Page.ClientScript;
            Type rsType = this.GetType();
            if (!cs.IsClientScriptIncludeRegistered("ScrollableListBox"))
            {
                cs.RegisterClientScriptInclude("ScrollableListBox", cs.GetWebResourceUrl(rsType, "Evyatar.Web.Controls.JavaScript.ScrollableListBox.js"));
            }
            cs.RegisterStartupScript(rsType, "ScrollableListBoxStartup" + this.UniqueID, string.Format("__ScrollableListBoxRefineHeightAndWidth('{0}');", this.ClientID), true);

            base.OnInit(e);
        }
        #endregion 

        #region Render
        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter"></see> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            string overflowX = "auto";
            string overflowY = "auto";

            #region Design Time twick
            if (DesignMode)
            {
                base.Width = Width;
                base.Height = Height;

                
                overflowX = "scroll";
                if (! Height.IsEmpty)
                {
                    overflowY = "scroll";
                }
            }
            #endregion

            writer.Write(string.Format("<div style='OVERFLOW-X: {2};OVERFLOW-Y: {3}; {0}' id='{1}'>", AddStyleAttributesToRender(), ClientID + "_div", overflowX, overflowY));
            base.Render(writer);
            writer.Write("</div>");
        }
        #endregion

        #endregion

        #region Overridden Properties

        #region Width
        /// <summary>
        /// Gets or sets the width of the Web server control.
        /// </summary>
        /// <value></value>
        /// <returns>A <see cref="T:System.Web.UI.WebControls.Unit"></see> that represents the width of the control. The default is <see cref="F:System.Web.UI.WebControls.Unit.Empty"></see>.</returns>
        /// <exception cref="T:System.ArgumentException">The width of the Web server control was set to a negative value. </exception>
        public override Unit Width
        {
            get
            {
                object o = ViewState["Width"];
                if (null == o)
                    return Unit.Empty;
                return (Unit)o;
            }
            set
            {
                if (value.Value < 0)
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                ViewState["Width"] = value;
            }
        }
        #endregion

        #region Height
        /// <summary>
        /// Gets or sets the height of the Web server control.
        /// </summary>
        /// <value></value>
        /// <returns>A <see cref="T:System.Web.UI.WebControls.Unit"></see> that represents the height of the control. The default is <see cref="F:System.Web.UI.WebControls.Unit.Empty"></see>.</returns>
        /// <exception cref="T:System.ArgumentException">The height was set to a negative value.</exception>
        public override Unit Height
        {
            get
            {
                object o = ViewState["Height"];
                if (null == o)
                    return Unit.Empty;
                return (Unit)o;
            }
            set
            {
                if (value.Value < 0)
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                ViewState["Height"] = value;
            }
        }
        #endregion

        #region BorderColor

        /// <summary>
        /// Gets or sets the border color of the control.
        /// </summary>
        /// <value></value>
        /// <returns>A <see cref="T:System.Drawing.Color"></see> object that represents the border color of the control.</returns>
        [Browsable(true)]
        [Category("Appearance")]
        [Description("Color of the border around the control"), DefaultValue(typeof(Color), "")]
        [TypeConverter(typeof(WebColorConverter))]
        public override Color BorderColor
        {
            get
            {
                object o = ViewState["BorderColor"];
                if (null == o)
                    return Color.Empty;
                return (Color)o;
            }
            set
            {
                ViewState["BorderColor"] = value;
            }
        }
        #endregion

        #region BorderStyle

        /// <summary>
        /// Gets or sets the border style of the control.
        /// </summary>
        /// <value></value>
        /// <returns>One of the <see cref="T:System.Web.UI.WebControls.BorderStyle"></see> values.</returns>
        [Browsable(true)]
        [DefaultValue(BorderStyle.NotSet)]
        [Category("Appearance")]
        [Description("Style of the border around the control")]
        public override BorderStyle BorderStyle
        {
            get
            {
                object o = ViewState["BorderStyle"];
                if (null == o)
                    return System.Web.UI.WebControls.BorderStyle.NotSet;
                return (BorderStyle)o;
            }
            set
            {
                ViewState["BorderStyle"] = value;
            }
        }
        #endregion 

        #region BorderWidth
        /// <summary>
        /// Gets or sets the border width for the control.
        /// </summary>
        /// <value></value>
        /// <returns>A <see cref="T:System.Web.UI.WebControls.Unit"></see> object that represents the border width of the control.</returns>
        [Browsable(true)]
        [Description("Width of the border around the control")]
        [Category("Appearance")]
        [DefaultValue(typeof(Unit), "")]
        public override Unit BorderWidth
        {
            get
            {
                object o = ViewState["BorderWidth"];
                if (null == o)
                    return Unit.Empty;
                return (Unit)o;
            }
            set
            {
                if (value.Value < 0)
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                ViewState["BorderWidth"] = value;
            }
        }
        #endregion 

        #endregion

        #region Private methodes
        /// <summary>
        /// Adds the style attributes to render.
        /// </summary>
        /// <returns></returns>
        private string AddStyleAttributesToRender()
        {
            StringBuilder sb = new StringBuilder("", 16);

            if (!Width.IsEmpty)
                sb.Append(string.Format("WIDTH: {0};", Width.ToString(CultureInfo.InvariantCulture)));
            if (!Height.IsEmpty)
                sb.Append(string.Format("HEIGHT: {0};", Height.ToString(CultureInfo.InvariantCulture)));
            if (! BorderColor.IsEmpty) 
                sb.Append(string.Format("BORDER-COLOR: {0};", ColorTranslator.ToHtml(BorderColor)));
            if (!BorderWidth.IsEmpty)
                sb.Append(string.Format("BORDER-WIDTH: {0};", BorderWidth.ToString(CultureInfo.InvariantCulture)));
            if (BorderStyle != BorderStyle.NotSet)
                sb.Append(string.Format("BORDER-STYLE: {0};", BorderStyle.ToString()));

            return sb.ToString();
        }
        #endregion 
    }
}
