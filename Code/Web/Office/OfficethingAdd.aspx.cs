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

public partial class Office_OfficethingAdd : System.Web.UI.Page
{


	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			SDLX.Common.PublicMethod.CheckSession();
			
		}
	}
	protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
	{
		SDLX.BLL.ERPOfficething Model = new SDLX.BLL.ERPOfficething();
		
		Model.ShenQingThing=this.txtShenQingThing.Text.ToString();
		Model.TypeStr=this.txtTypeStr.Text.ToString();
		Model.ShengQingNum=this.txtShengQingNum.Text.ToString();
		Model.NowState="等待审核";
		Model.UserName=SDLX.Common.PublicMethod.GetSessionValue("UserName");
		Model.TimeStr=DateTime.Now;
		
		Model.Add();
		
		//写系统日志
		SDLX.BLL.ERPRiZhi MyRiZhi = new SDLX.BLL.ERPRiZhi();
		MyRiZhi.UserName = SDLX.Common.PublicMethod.GetSessionValue("UserName");
        MyRiZhi.DoSomething = "用户添加办公用品信息(" + this.txtShenQingThing.Text + ")";
		MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
		MyRiZhi.Add();

        SDLX.Common.MessageBox.ShowAndRedirect(this, "办公用品信息添加成功！", "OfficeShengQing.aspx");
	}
}
