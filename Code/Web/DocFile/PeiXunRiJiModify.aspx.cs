using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class DocFile_PeiXunRiJiModify : System.Web.UI.Page
{


	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			SDLX.Common.PublicMethod.CheckSession();
			SDLX.BLL.ERPPeiXunRiJi Model = new SDLX.BLL.ERPPeiXunRiJi();
			Model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
			this.txtPeiXunName.Text=Model.PeiXunName.ToString();
			this.txtRiJiTitle.Text=Model.RiJiTitle.ToString();
			this.txtRiJiDate.Text=Model.RiJiDate.ToString();
			this.txtRiJiContent.Text=Model.RiJiContent.ToString();
			this.txtUserName.Text=Model.UserName.ToString();
			this.txtTimeStr.Text=Model.TimeStr.ToString();
		}
	}
	protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
	{
		SDLX.BLL.ERPPeiXunRiJi Model = new SDLX.BLL.ERPPeiXunRiJi();
		
		Model.ID = int.Parse(Request.QueryString["ID"].ToString());
		Model.PeiXunName=this.txtPeiXunName.Text.ToString();
		Model.RiJiTitle=this.txtRiJiTitle.Text.ToString();
		Model.RiJiDate=this.txtRiJiDate.Text.ToString();
		Model.RiJiContent=this.txtRiJiContent.Text.ToString();
		Model.UserName=this.txtUserName.Text.ToString();
		Model.TimeStr=DateTime.Parse(this.txtTimeStr.Text);
		
		Model.Update();
		
		//写系统日志
		SDLX.BLL.ERPRiZhi MyRiZhi = new SDLX.BLL.ERPRiZhi();
		MyRiZhi.UserName = SDLX.Common.PublicMethod.GetSessionValue("UserName");
        MyRiZhi.DoSomething = "用户修改培训日志信息(" + this.txtPeiXunName.Text + ")";
		MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
		MyRiZhi.Add();

        SDLX.Common.MessageBox.ShowAndRedirect(this, "培训日志信息修改成功！", "PeiXunRiJi.aspx?PeiXunName="+Request.QueryString["PeiXunName"].ToString());
	}
}
