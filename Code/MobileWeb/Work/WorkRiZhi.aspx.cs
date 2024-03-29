﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;

public partial class Work_WorkRiZhi : System.Web.UI.Page
{
    public List<ERPWorkRiZhi> EmailList = new List<ERPWorkRiZhi>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            SDLX.Common.PublicMethod.CheckSession();
            DataBindToGridview();
        }
    }
    public void DataBindToGridview()
    {
        DataEntityDataContext context = new DataEntityDataContext();
        SDLX.BLL.ERPWorkRiZhi MyLanEmail = new SDLX.BLL.ERPWorkRiZhi();
        var T = context.ERPWorkRiZhi.Where(p => p.UserName == SDLX.Common.PublicMethod.GetSessionValue("UserName")).OrderByDescending(p => p.ID);
        EmailList = T.ToList();
    }

}