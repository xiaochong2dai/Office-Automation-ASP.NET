﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Mobile_MobileSmsAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            SDLX.Common.PublicMethod.CheckSession();
            try
            {
                this.TextBox1.Text = Request.QueryString["ShouJilist"].ToString();
            }
            catch
            { }
        }
    }
    protected void ImageButton1_Click(object sender, EventArgs e)
    {
        SDLX.BLL.ERPMobile MyModel = new SDLX.BLL.ERPMobile();

        MyModel.ToUserList = this.TextBox1.Text;
        MyModel.ContentStr = this.TextBox2.Text;
        MyModel.FaSongUser = SDLX.Common.PublicMethod.GetSessionValue("UserName");
        Mobile.SendSMS(MyModel.FaSongUser, MyModel.ToUserList, MyModel.ContentStr);

        MyModel.ToUserList = "内部人员：" + this.TextBox1.Text;
        MyModel.Add();




        //写系统日志
        SDLX.BLL.ERPRiZhi MyRiZhi = new SDLX.BLL.ERPRiZhi();
        MyRiZhi.UserName = SDLX.Common.PublicMethod.GetSessionValue("UserName");
        MyRiZhi.DoSomething = "用户添加新内部手机短信(" + this.TextBox2.Text + ")";
        MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
        MyRiZhi.Add();

        SDLX.Common.MessageBox.ShowAndRedirect(this, "手机短信发送成功！", "MobileSms.aspx");
    }
    protected void ImageButton2_Click(object sender, EventArgs e)
    {
        SDLX.BLL.ERPMobile MyModel = new SDLX.BLL.ERPMobile();

        MyModel.ToUserList = this.TextBox3.Text;
        MyModel.ContentStr = this.TextBox4.Text;
        MyModel.FaSongUser = SDLX.Common.PublicMethod.GetSessionValue("UserName");
        Mobile.SendSMS2(MyModel.FaSongUser, MyModel.ToUserList, MyModel.ContentStr);

        MyModel.ToUserList = "外部人员：" + this.TextBox3.Text;
        MyModel.Add();



        //写系统日志
        SDLX.BLL.ERPRiZhi MyRiZhi = new SDLX.BLL.ERPRiZhi();
        MyRiZhi.UserName = SDLX.Common.PublicMethod.GetSessionValue("UserName");
        MyRiZhi.DoSomething = "用户添加新外部手机短信(" + this.TextBox4.Text + ")";
        MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
        MyRiZhi.Add();

        SDLX.Common.MessageBox.ShowAndRedirect(this, "手机短信发送成功！", "MobileSms.aspx");
    }
}