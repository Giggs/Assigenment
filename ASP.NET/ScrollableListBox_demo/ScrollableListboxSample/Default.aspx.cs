using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ListItem li;
            foreach (string strKnownColor in Enum.GetNames(typeof(KnownColor)))
            {
                if (! Color.FromName(strKnownColor).IsSystemColor)
                {
                    li = new ListItem(strKnownColor, strKnownColor);
                    ddlBorderColor.Items.Add(li);
                    li.Attributes.Add("Style", string.Format("BACKGROUND-COLOR: {0}", strKnownColor ));
                }
            }
            foreach (string strBorderSyle in Enum.GetNames(typeof(BorderStyle)))
            {
                ddlBorderStyle.Items.Add(strBorderSyle);
            }
        }
        else
        {
            //Because ListItems attribute not saved on ViewState we restor the background color
            foreach (ListItem li in ddlBorderColor.Items)
            {
                li.Attributes.Add("Style", string.Format("BACKGROUND-COLOR: {0}", li.Text));
            }
        }
    }
    /// <summary>
    /// Handles the CheckedChanged event of the chkWidth control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
    protected void chkWidth_CheckedChanged(object sender, EventArgs e)
    {
        EnableOrDisableWidth(chkWidth.Checked);        
    }

    /// <summary>
    /// Handles the CheckedChanged event of the chkHeight control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
    protected void chkHeight_CheckedChanged(object sender, EventArgs e)
    {
        EnableOrDisableHeight(chkHeight.Checked);
    }

    /// <summary>
    /// Enables or disable the height controls.
    /// </summary>
    /// <param name="setEnable">if set to <c>true</c> [set enable].</param>
    private void EnableOrDisableHeight(bool setEnable)
    {
        pnlHeight.Enabled = rfvHeight.Enabled = cmvHeight.Enabled = setEnable;
    }

    /// <summary>
    /// Enables or disbale the width controls.
    /// </summary>
    /// <param name="setEnable">if set to <c>true</c> [set enable].</param>
    private void EnableOrDisableWidth(bool setEnable)
    {
        pnlWidth.Enabled = rfvWidth.Enabled = cmvWidth.Enabled = setEnable;
    }


    protected void btnApplyChanges_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            ScrollableListBox1.Rows = ListBox1.Rows = Convert.ToInt32(txtRows.Text);
            ScrollableListBox1.Width = ListBox1.Width = (chkWidth.Checked) ? Unit.Parse(string.Format("{0}{1}", txtWidth.Text.Trim(), ddlWidth.SelectedValue)) : Unit.Empty;
            ScrollableListBox1.Height = ListBox1.Height = (chkHeight.Checked) ? Unit.Parse(string.Format("{0}{1}", txtHeight.Text.Trim(), ddlHeight.SelectedValue)) : Unit.Empty;
            ScrollableListBox1.BorderColor = ListBox1.BorderColor = Color.FromName(ddlBorderColor.SelectedValue);
            ScrollableListBox1.BorderStyle = ListBox1.BorderStyle = (BorderStyle)Enum.Parse(typeof(BorderStyle), ddlBorderStyle.SelectedValue);
            ScrollableListBox1.BorderWidth = ListBox1.BorderWidth = Unit.Pixel(Convert.ToInt32(txtBorderWidth.Text.Trim()));
        }
    }

    protected void btnNewItem_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            string strNewItem = HttpUtility.HtmlEncode(txtNewItem.Text);
            ScrollableListBox1.Items.Add(strNewItem);
            ListBox1.Items.Add(strNewItem);
            txtNewItem.Text = "";
        }
    }
  }
