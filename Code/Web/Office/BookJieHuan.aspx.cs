
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

public partial class Office_BookJieHuan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            SDLX.Common.PublicMethod.CheckSession();
            DataBindToGridview();

            //设定按钮权限            
            ImageButton1.Visible = SDLX.Common.PublicMethod.StrIFIn("|A023a|", SDLX.Common.PublicMethod.GetSessionValue("QuanXian"));
            ImageButton5.Visible = SDLX.Common.PublicMethod.StrIFIn("|A023m|", SDLX.Common.PublicMethod.GetSessionValue("QuanXian"));
            ImageButton3.Visible = SDLX.Common.PublicMethod.StrIFIn("|A023d|", SDLX.Common.PublicMethod.GetSessionValue("QuanXian"));
            ImageButton2.Visible = SDLX.Common.PublicMethod.StrIFIn("|A023e|", SDLX.Common.PublicMethod.GetSessionValue("QuanXian"));
        }
    }
    #region  分页方法
    protected void ButtonGo_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (GoPage.Text.Trim().ToString() == "")
            {
                Response.Write("<script language='javascript'>alert('页码不可以为空!');</script>");
            }
            else if (GoPage.Text.Trim().ToString() == "0" || Convert.ToInt32(GoPage.Text.Trim().ToString()) > GVData.PageCount)
            {
                Response.Write("<script language='javascript'>alert('页码不是一个有效值!');</script>");
            }
            else if (GoPage.Text.Trim() != "")
            {
                int PageI = Int32.Parse(GoPage.Text.Trim()) - 1;
                if (PageI >= 0 && PageI < (GVData.PageCount))
                {
                    GVData.PageIndex = PageI;
                }
            }

            if (TxtPageSize.Text.Trim().ToString() == "")
            {
                Response.Write("<script language='javascript'>alert('每页显示行数不可以为空!');</script>");
            }
            else if (TxtPageSize.Text.Trim().ToString() == "0")
            {
                Response.Write("<script language='javascript'>alert('每页显示行数不是一个有效值!');</script>");
            }
            else if (TxtPageSize.Text.Trim() != "")
            {
                try
                {
                    int MyPageSize = int.Parse(TxtPageSize.Text.ToString().Trim());
                    this.GVData.PageSize = MyPageSize;
                }
                catch
                {
                    Response.Write("<script language='javascript'>alert('每页显示行数不是一个有效值!');</script>");
                }
            }

            DataBindToGridview();
        }
        catch
        {
            DataBindToGridview();
            Response.Write("<script language='javascript'>alert('请输入有效数字！');</script>");
        }
    }
    protected void PagerButtonClick(object sender, ImageClickEventArgs e)
    {
        //获得Button的参数值
        string arg = ((ImageButton)sender).CommandName.ToString();
        switch (arg)
        {
            case ("Next"):
                if (this.GVData.PageIndex < (GVData.PageCount - 1))
                    GVData.PageIndex++;
                break;
            case ("Pre"):
                if (GVData.PageIndex > 0)
                    GVData.PageIndex--;
                break;
            case ("Last"):
                try
                {
                    GVData.PageIndex = (GVData.PageCount - 1);
                }
                catch
                {
                    GVData.PageIndex = 0;
                }

                break;
            default:
                //本页值
                GVData.PageIndex = 0;
                break;
        }
        DataBindToGridview();
    }
    #endregion
    protected void GVData_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        SDLX.Common.PublicMethod.GridViewRowDataBound(e);
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        DataBindToGridview();
    }
	public void DataBindToGridview()
	{
		SDLX.BLL.ERPBookJieHuan MyModel = new SDLX.BLL.ERPBookJieHuan();
		GVData.DataSource = MyModel.GetList("BookName Like '%" + this.TextBox1.Text + "%' and UserName='"+SDLX.Common.PublicMethod.GetSessionValue("UserName")+"' order by ID desc");
		GVData.DataBind();
		LabPageSum.Text = Convert.ToString(GVData.PageCount);
		LabCurrentPage.Text = Convert.ToString(((int)GVData.PageIndex + 1));
		this.GoPage.Text = LabCurrentPage.Text.ToString();
	}
	protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
	{
		Response.Redirect("BookJieHuanAdd.aspx");
	}
	protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
	{
		string IDlist = SDLX.Common.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
		if (SDLX.DBUtility.DbHelperSQL.ExecuteSQL("delete from ERPBookJieHuan where ID in (" + IDlist + ")") == -1)
		{
			Response.Write("<script>alert('删除选中记录时发生错误！请重新登陆后重试！');</script>");
		}
		else
		{
			DataBindToGridview();
			//写系统日志
			SDLX.BLL.ERPRiZhi MyRiZhi = new SDLX.BLL.ERPRiZhi();
			MyRiZhi.UserName = SDLX.Common.PublicMethod.GetSessionValue("UserName");
            MyRiZhi.DoSomething = "用户删除图书借还记录信息";
			MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
			MyRiZhi.Add();
		}
	}
	protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
	{
		string IDList = "0";
		for (int i = 0; i < GVData.Rows.Count; i++)
		{
			Label LabVis = (Label)GVData.Rows[i].FindControl("LabVisible");
			IDList = IDList + "," + LabVis.Text.ToString();
		}
		Hashtable MyTable = new Hashtable();
		MyTable.Add("BookName", "图书名称");
		MyTable.Add("JieShuDate", "借书日期");
		MyTable.Add("GuiHuanDate", "归还日期");
		MyTable.Add("JieHuanState", "借还状态");
		MyTable.Add("UserName", "借书人");
		MyTable.Add("TimeStr", "申请时间");
		SDLX.Common.DataToExcel.GridViewToExcel(SDLX.DBUtility.DbHelperSQL.GetDataSet("select  BookName,JieShuDate,GuiHuanDate,JieHuanState,UserName,TimeStr  from ERPBookJieHuan where ID in (" + IDList + ") order by ID desc"), MyTable, "Excel报表");
	}
	protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
	{
		string CheckStr = SDLX.Common.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
		string[] CheckStrArray = CheckStr.Split(',');
		Response.Redirect("BookJieHuanModify.aspx?ID=" + CheckStrArray[0].ToString());
	}
}
