using System.Text;

namespace UI.Web.Models
{
    public class ClassBootStrep
    {


        public static string GetAjaxLoader()
        {
            return "<div><img src=@'img\ajax-loader.gif'></div>";
        }

        public static string GetImage(string pPathImage, string pTitle, string pSubTitle)
        {
            return "<div class='col-xs-6 col-sm-3 placeholder'>" +
                   "<img src='" + pPathImage + "' class='img-circle' alt='Generic placeholder thumbnail'>" +
                   "<h4>" + pTitle + "</h4>" +
                   "<span class='text-muted'>" + pSubTitle + "</span>" +
                   "</div>";

            //"<img src='" + pPathImage + "' class='img-circle'>";
        }

        public static string GetAlert(string pContent)
        {
            return "<button type='button' class='close' data-dismiss='alert'><span aria-hidden='true'>&times;</span><span class='sr-only'>" +
                    pContent + "</span></button>";
        }

        public static string GetPageHeader(string pTitle, string pSubTitle)
        {
            return "<div class='page-header' style='margin-left:10px; margin-top:0px; margin-bottom:0px; padding:0px; border-style:none;'>" +
                   "<h1>" + pTitle + " - <small>" + pSubTitle + "</small></h1>" +
                   "</div>";
        }

        public static string GetProgressBar(int pValor)
        {
            return "<div class='progress'>" +
                   "<div class='progress-bar progress-bar-striped active'  role='progressbar' aria-valuenow='" + pValor + "' aria-valuemin='0' aria-valuemax='100' style='width: 45%'>" +
                   "<span class='sr-only'>" + pValor + "% Complete</span>" +
                   "</div>" +
                   "</div>";
        }

        public static string GetAlertSucess(string pTitle, string pContent)
        {
            return "<div class='alert alert-success' role='alert'>" +
                   "<strong>" + pTitle + ": </strong>" + pContent +
                   "</div>";
        }

        public static string GetAlertInfo(string pTitle, string pContent,string MSG =null)
        {
            if(MSG != null)
            {
                return "<div class='alert alert-info' role='alert'>" +
                   "<strong>" + pTitle + ": </strong>" + MSG +
                   "</div>";
            }
            else { 
            return "<div class='alert alert-info' role='alert'>" +
                   "<strong>" + pTitle + ": </strong>" + pContent +
                   "</div>";
            }
        }

        public static string GetAlertWarning(string pTitle, string pContent)
        {
            return "<div class='alert alert-warning' role='alert'>" +
                   "<strong>" + pTitle + ": </strong>" + pContent +
                   "</div>";
        }

        public static string GetAlertDanger(string pTitle, string pContent)
        {
            return "<div class='alert alert-danger' role='alert'>" +
                   "<strong>" + pTitle + ": </strong>" + pContent +
                   "</div>";
        }

        public static string GetAlertDismissibleSucess(string pTitle, string pContent)
        {
            return "<div class='alert alert-success alert-dismissible' role='alert' style='text-align:center; align-self:center;'>" +
                   "<button type='button' class='close' data-dismiss='alert'><span aria-hidden='true'>&times;</span><span class='sr-only'>Close</span></button>" +
                   "<strong>" + pTitle + ": </strong>" + pContent + "</div>";
        }

        public static string GetAlertDismissibleInfo(string pTitle, string pContent)
        {
            return "<div class='alert alert-info alert-dismissible' role='alert'>" +
                   "<button type='button' class='close' data-dismiss='alert'><span aria-hidden='true'>&times;</span><span class='sr-only'>Close</span></button>" +
                   "<strong>" + pTitle + ": </strong>" + pContent + "</div>";
        }

        public static string GetAlertDismissibleWarning(string pTitle, string pContent)
        {
            return "<div class='alert alert-warning alert-dismissible' role='alert'>" +
                   "<button type='button' class='close' data-dismiss='alert'><span aria-hidden='true'>&times;</span><span class='sr-only'>Close</span></button>" +
                   "<strong>" + pTitle + ": </strong>" + pContent + "</div>";
        }

        public static string GetAlertDismissibleDanger(string pTitle, string pContent)
        {
            return "<div class='alert alert-danger alert-dismissible' role='alert'>" +
                   "<button type='button' class='close' data-dismiss='alert'><span aria-hidden='true'>&times;</span><span class='sr-only'>Close</span></button>" +
                   "<strong>" + pTitle + ": </strong>" + pContent + "</div>";
        }

        public static string GetModal(string pTitle, string pContent)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<div id=\"myModal\" class=\"modal fade\" role=\"dialog\">");
            sb.Append("<div class=\"modal-dialog modal-sm\">");

            sb.Append("<!-- Modal content-->");
            sb.Append("<div class=\"modal-content\">");
            sb.Append("<div class=\"modal-header\">");
            sb.Append("<button type=\"button\" class=\"close\" data-dismiss=\"modal\">&times;</button>");

            sb.Append("<h4 class=\"modal-title\">");
            sb.Append(pTitle);
            sb.Append("</h4>");
            sb.Append("</div>");
            sb.Append("<div class=\"modal-body\">");
            sb.Append("<p id=\"modaltext\">");
            sb.Append(pContent);
            sb.Append("</p>");
            sb.Append("</div>");

            sb.Append("<div class=\"modal-footer\">");
            sb.Append("<button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">Fechar</button>");
            sb.Append("</div>");
            sb.Append("</div>");
            sb.Append("</div>");
            sb.Append("</div>");

            return sb.ToString();
        }
    }
}
