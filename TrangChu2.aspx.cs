﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App_Code;

public partial class TrangChu2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Xaydung cart = new Xaydung();
        cart.CreateItem();
        Session["Cart"] = cart;
    }
}