﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    
    #line 6 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using System.Web.Mvc.Ajax;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using System.Web.Routing;
    
    #line default
    #line hidden
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 3 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/UserOnline/_List_Data.cshtml")]
    public partial class _Areas_Admin_Views_UserOnline__List_Data_cshtml : System.Web.Mvc.WebViewPage<IList<XCode.Membership.UserOnline>>
    {
        public _Areas_Admin_Views_UserOnline__List_Data_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 10 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;
    var fields = ViewBag.Fields as List<FieldItem>;

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n            <th");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 560), Tuple.Create("\"", 599)
            
            #line 18 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 567), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("ID"))
            
            #line default
            #line hidden
, 567), false)
);

WriteLiteral(">编号</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 652), Tuple.Create("\"", 693)
            
            #line 19 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 659), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Name"))
            
            #line default
            #line hidden
, 659), false)
);

WriteLiteral(">名称</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 746), Tuple.Create("\"", 788)
            
            #line 20 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 753), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Times"))
            
            #line default
            #line hidden
, 753), false)
);

WriteLiteral(">次数</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 841), Tuple.Create("\"", 884)
            
            #line 21 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 848), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Status"))
            
            #line default
            #line hidden
, 848), false)
);

WriteLiteral(">状态</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 937), Tuple.Create("\"", 984)
            
            #line 22 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 944), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("OnlineTime"))
            
            #line default
            #line hidden
, 944), false)
);

WriteLiteral(">在线时间</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1039), Tuple.Create("\"", 1084)
            
            #line 23 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1046), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("CreateIP"))
            
            #line default
            #line hidden
, 1046), false)
);

WriteLiteral(">创建地址</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1139), Tuple.Create("\"", 1189)
            
            #line 24 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1146), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("CreateAddress"))
            
            #line default
            #line hidden
, 1146), false)
);

WriteLiteral(">物理地址</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1244), Tuple.Create("\"", 1291)
            
            #line 25 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1251), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("CreateTime"))
            
            #line default
            #line hidden
, 1251), false)
);

WriteLiteral(">创建时间</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1346), Tuple.Create("\"", 1393)
            
            #line 26 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1353), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("UpdateTime"))
            
            #line default
            #line hidden
, 1353), false)
);

WriteLiteral(">修改时间</a></th>\r\n");

            
            #line 27 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 27 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
             if (ManageProvider.User.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">操作</th>\r\n");

            
            #line 30 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 34 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
        
            
            #line default
            #line hidden
            
            #line 34 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
         foreach (var entity in Model)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral(">");

            
            #line 37 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                                                                 Write(entity.ID);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 38 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
               Write(entity.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 39 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                                  Write(entity.Times.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 40 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
               Write(entity.Status);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 41 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                                  Write(entity.OnlineTime.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 42 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
               Write(entity.CreateIP);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 43 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
               Write(entity.CreateAddress);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 44 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
               Write(entity.CreateTime.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 45 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
               Write(entity.UpdateTime.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 46 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 46 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                 if (ManageProvider.User.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 49 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                   Write(Html.Partial("_List_Data_Action", (Object)entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");

            
            #line 51 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 53 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>");

        }
    }
}
#pragma warning restore 1591
