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

public partial class Car_CarShiYongAdd : System.Web.UI.Page
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
		SDLX.BLL.ERPCarShiYong Model = new SDLX.BLL.ERPCarShiYong();
		
		Model.CarName=this.txtCarName.Text.ToString();
		Model.DriverUser=this.txtDriverUser.Text.ToString();
		Model.YongCheUser=this.txtYongCheUser.Text.ToString();
		Model.YongCheBuMen=this.txtYongCheBuMen.Text.ToString();
		Model.QiShiTime=this.txtQiShiTime.Text.ToString();
		Model.JieShuTime=this.txtJieShuTime.Text.ToString();
		Model.MuDiDi=this.txtMuDiDi.Text.ToString();
		Model.LiCheng=this.txtLiCheng.Text.ToString();
		Model.ShengQingUser=this.txtShengQingUser.Text.ToString();
		Model.DiaoDuUser=this.txtDiaoDuUser.Text.ToString();
		Model.ShengQingShiYou=this.txtShengQingShiYou.Text.ToString();
		Model.NowState="等待审核";
		Model.UserName=SDLX.Common.PublicMethod.GetSessionValue("UserName");
		Model.TimeStr=DateTime.Now;
		Model.BackInfo=this.txtBackInfo.Text.ToString();
		
		Model.Add();
		
		//写系统日志
		SDLX.BLL.ERPRiZhi MyRiZhi = new SDLX.BLL.ERPRiZhi();
		MyRiZhi.UserName = SDLX.Common.PublicMethod.GetSessionValue("UserName");
		MyRiZhi.DoSomething = "用户添加车辆使用信息(" + this.txtCarName.Text + ")";
		MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
		MyRiZhi.Add();

        SDLX.Common.MessageBox.ShowAndRedirect(this, "车辆使用信息添加成功！", "CarShiYong.aspx");
	}
}
