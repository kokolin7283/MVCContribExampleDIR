# MVCContribExampleDIR
ASP.NET MVC的MvcContrib使用範例

建置步驟說明：

    建立MVCContribExampleDIR方案

    裡面建立主要解決專案MVCContrbExample(MVC)

    在MVCContribExample方案資料夾內再新增一個管理後台的專案MVCContribExample.Admin(MVC)

    刪除MVCContribExample.Admin專案內的Global.asax檔案

    在MVCContrbExample.Admin專案內執行Nuget參考加入MvcContrib

    在MVCContrbExample.Admin專案內加入Class檔案AdminAreaRegistration並增加設定如範例

    修改MVCContrbExample.Admin專案內HomeController的Index方法，並修改View的呈現作為區分

    將MVCContrbExample.Admin專案內的View屬性中的建置動作改為內嵌資源

    在MVCContrbExample專案內新增一個資料夾並命名為Areas

    將MVCContribExampleDIR\MVCContribExample\Views\Web.config檔案複製到Areas資料夾內

    修改MVCContrbExample的RouterConfig.cs檔案內的設定，增加namespaces的註冊
