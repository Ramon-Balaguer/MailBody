﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailBodyPack
{
    public class MailBody
    {
        public static MailBlockFluent CreateBody()
        {
            var template = MailBodyTemplate.GetDefaultTemplate();
            var instance = new MailBlockFluent(template, null);
            return instance;
        }
        public static MailBlockFluent CreateBody(MailBlockFluent footer)
        {
            var template = MailBodyTemplate.GetDefaultTemplate();
            var instance = new MailBlockFluent(template, footer);
            return instance;
        }
        public static MailBlockFluent CreateBody(MailBodyTemplate template, MailBlockFluent footer)
        {
            var instance = new MailBlockFluent(template, footer);
            return instance;
        }
        public static MailBlockFluent CreateBlock()
        {
            var template = MailBodyTemplate.BlockTemplate();
            var instance = CreateBody(template, null);
            return instance;
        }
    }
    
    public class MailBodyTemplate
    {
        public string Paragraph { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Button { get; set; }
        public string Text { get; set; }
        public string LineBreak { get; set; }
        public string UnorderedList { get; set; }
        public string OrderedList { get; set; }
        public string ListItem { get; set; }

        public static MailBodyTemplate BlockTemplate()
        {
            var template = GetDefaultTemplate();
            template.Body = "{0}";
            return template;
        }

        public static MailBodyTemplate GetDefaultTemplate()
        {
            return new MailBodyTemplate
            {
                Paragraph = "<p style='font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;'>{0}</p>",
                Link = "<a href='{0}'>{1}</a>",
                Title = "<h1>{0}</h1>",
                Text = "{0}",
                UnorderedList = "<ul>{0}</ul>",
                OrderedList = "<ol>{0}</ol>",
                ListItem = "<li>{0}</li>",
                LineBreak = "</br>",
                Button = @"<table border='0' cellpadding='0' cellspacing='0' class='btn btn-primary' style='border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%; box-sizing: border-box;' width='100%'>
    <tbody>
    <tr>
        <td align='left' style='font-family: sans-serif; font-size: 14px; vertical-align: top; padding-bottom: 15px;' valign='top'>
        <table border='0' cellpadding='0' cellspacing='0' style='border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: auto;'>
            <tbody>
            <tr>
                <td style='font-family: sans-serif; font-size: 14px; vertical-align: top; background-color: #3498db; border-radius: 5px; text-align: center;' valign='top' bgcolor='#3498db' align='center'> <a href='{0}' target='_blank' style='display: inline-block; color: #ffffff; background-color: #3498db; border: solid 1px #3498db; border-radius: 5px; box-sizing: border-box; cursor: pointer; text-decoration: none; font-size: 14px; font-weight: bold; margin: 0; padding: 12px 25px; text-transform: capitalize; border-color: #3498db;'>{1}</a> </td>
            </tr>
            </tbody>
        </table>
        </td>
    </tr>
    </tbody>
</table>",
                Body = @"<!doctype html>
<html>
  <head>
    <meta name='viewport' content='width=device-width'>
    <meta http-equiv='Content-Type' content='text/html; charset=UTF-8'>
    <title>Simple Transactional Email</title>
    <style media='all' type='text/css'>
    @media all {{
      .btn-primary table td:hover {{
        background-color: #34495e !important;
      }}
      .btn-primary a:hover {{
        background-color: #34495e !important;
        border-color: #34495e !important;
      }}
    }}
    
    @media all {{
      .btn-secondary a:hover {{
        border-color: #34495e !important;
        color: #34495e !important;
      }}
    }}
    
    @media only screen and (max-width: 620px) {{
      table[class=body] h1 {{
        font-size: 28px !important;
        margin-bottom: 10px !important;
      }}
      table[class=body] h2 {{
        font-size: 22px !important;
        margin-bottom: 10px !important;
      }}
      table[class=body] h3 {{
        font-size: 16px !important;
        margin-bottom: 10px !important;
      }}
      table[class=body] p,
      table[class=body] ul,
      table[class=body] ol,
      table[class=body] td,
      table[class=body] span,
      table[class=body] a {{
        font-size: 16px !important;
      }}
      table[class=body] .wrapper,
      table[class=body] .article {{
        padding: 10px !important;
      }}
      table[class=body] .content {{
        padding: 0 !important;
      }}
      table[class=body] .container {{
        padding: 0 !important;
        width: 100% !important;
      }}
      table[class=body] .header {{
        margin-bottom: 10px !important;
      }}
      table[class=body] .main {{
        border-left-width: 0 !important;
        border-radius: 0 !important;
        border-right-width: 0 !important;
      }}
      table[class=body] .btn table {{
        width: 100% !important;
      }}
      table[class=body] .btn a {{
        width: 100% !important;
      }}
      table[class=body] .img-responsive {{
        height: auto !important;
        max-width: 100% !important;
        width: auto !important;
      }}
      table[class=body] .alert td {{
        border-radius: 0 !important;
        padding: 10px !important;
      }}
      table[class=body] .span-2,
      table[class=body] .span-3 {{
        max-width: none !important;
        width: 100% !important;
      }}
      table[class=body] .receipt {{
        width: 100% !important;
      }}
    }}
    
    @media all {{
      .ExternalClass {{
        width: 100%;
      }}
      .ExternalClass,
      .ExternalClass p,
      .ExternalClass span,
      .ExternalClass font,
      .ExternalClass td,
      .ExternalClass div {{
        line-height: 100%;
      }}
      .apple-link a {{
        color: inherit !important;
        font-family: inherit !important;
        font-size: inherit !important;
        font-weight: inherit !important;
        line-height: inherit !important;
        text-decoration: none !important;
      }}
    }}
    </style>
  </head>
  <body class='' style='font-family: sans-serif; -webkit-font-smoothing: antialiased; font-size: 14px; line-height: 1.4; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%; background-color: #f6f6f6; margin: 0; padding: 0;'>
    <table border='0' cellpadding='0' cellspacing='0' class='body' style='border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%; background-color: #f6f6f6;' width='100%' bgcolor='#f6f6f6'>
      <tr>
        <td style='font-family: sans-serif; font-size: 14px; vertical-align: top;' valign='top'>&nbsp;</td>
        <td class='container' style='font-family: sans-serif; font-size: 14px; vertical-align: top; display: block; Margin: 0 auto !important; max-width: 580px; padding: 10px; width: 580px;' width='580' valign='top'>
          <div class='content' style='box-sizing: border-box; display: block; Margin: 0 auto; max-width: 580px; padding: 10px;'>

            <!-- START CENTERED WHITE CONTAINER -->
            <span class='preheader' style='color: transparent; display: none; height: 0; max-height: 0; max-width: 0; opacity: 0; overflow: hidden; mso-hide: all; visibility: hidden; width: 0;'>This is preheader text. Some clients will show this text as a preview.</span>
            <table class='main' style='border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%; background: #fff; border-radius: 3px;' width='100%'>

              <!-- START MAIN CONTENT AREA -->
              <tr>
                <td class='wrapper' style='font-family: sans-serif; font-size: 14px; vertical-align: top; box-sizing: border-box; padding: 20px;' valign='top'>
                  <table border='0' cellpadding='0' cellspacing='0' style='border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%;' width='100%'>
                    <tr>
                      <td style='font-family: sans-serif; font-size: 14px; vertical-align: top;' valign='top'>
                        {0}
                      </td>
                    </tr>
                  </table>
                </td>
              </tr>

              <!-- END MAIN CONTENT AREA -->
              </table>

            <!-- START FOOTER -->
            <div class='footer' style='clear: both; padding-top: 10px; text-align: center; width: 100%;'>
              <table border='0' cellpadding='0' cellspacing='0' style='border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%;' width='100%'>
                <tr>
                  <td class='content-block' style='font-family: sans-serif; vertical-align: top; padding-top: 10px; padding-bottom: 10px; font-size: 12px; color: #999999; text-align: center;' valign='top' align='center'>
                    <span class='apple-link' style='color: #999999; font-size: 12px; text-align: center;'>{1}</span>
                  </td>
                </tr>
              </table>
            </div>

            <!-- END FOOTER -->
            
<!-- END CENTERED WHITE CONTAINER --></div>
        </td>
        <td style='font-family: sans-serif; font-size: 14px; vertical-align: top;' valign='top'>&nbsp;</td>
      </tr>
    </table>
  </body>
</html>"
            };
        }
    }

    public class MailBlockFluent
    {
        private StringBuilder _body = new StringBuilder();
        private MailBodyTemplate _template;
        private MailBlockFluent _footer;
        
        public MailBlockFluent(MailBodyTemplate template, MailBlockFluent footer)
        {
            _template = template;
            _footer = footer;
        }

        public MailBlockFluent Title(string content)
        {
            _body.Append(string.Format(_template.Title, HtmlEncode(content)));
            return this;
        }
        public MailBlockFluent Paragraph(string content)
        {
            _body.Append(string.Format(_template.Paragraph, HtmlEncode(content)));
            return this;
        }
        public MailBlockFluent Paragraph(MailBlockFluent block)
        {
            _body.Append(block.ToString());
            return this;
        }
        public MailBlockFluent Link(string link, string text)
        {
            _body.Append(string.Format(_template.Link, HtmlEncode(link), HtmlEncode(text)));
            return this;
        }
        public MailBlockFluent Button(string link, string text)
        {
            _body.Append(string.Format(_template.Button, HtmlEncode(link), HtmlEncode(text)));
            return this;
        }
        public MailBlockFluent Text(string text)
        {
            _body.Append(string.Format(_template.Text, HtmlEncode(text)));
            return this;
        }
        public MailBlockFluent Raw(string html)
        {
            _body.Append(html);
            return this;
        }
        public MailBlockFluent LineBreak()
        {
            _body.Append(_template.LineBreak);
            return this;
        }

        public MailBlockFluent UnorderedList(IEnumerable<MailBlockFluent> items)
        {
            var builder = new StringBuilder();
            foreach (var item in items)
            {
                builder.Append(string.Format(_template.ListItem, HtmlEncode(item.ToString())));
            }
            _body.Append(string.Format(_template.UnorderedList, builder.ToString()));
            return this;
        }

        public MailBlockFluent OrderedList(IEnumerable<MailBlockFluent> items)
        {
            var builder = new StringBuilder();
            foreach (var item in items)
            {
                builder.Append(string.Format(_template.ListItem, HtmlEncode(item.ToString())));
            }
            _body.Append(string.Format(_template.OrderedList, builder.ToString()));
            return this;
        }

        public override string ToString()
        {
            return string.Format(_template.Body, _body.ToString(),
                _footer != null ? _footer.ToString() : string.Empty);
        }

        private static string HtmlEncode(string unescapeText)
        {
            var builder = new StringBuilder();
            foreach (var item in unescapeText)
            {
                switch (item)
                {
                    case '<':
                        builder.Append("&lt;");
                        break;
                    case '>':
                        builder.Append("&gt;");
                        break;
                    case '\'':
                        builder.Append("&apos;");
                        break;
                    case '"':
                        builder.Append("&quot;");
                        break;
                    default:
                        builder.Append(item);
                        break;
                }
            }
            return builder.ToString();
        }
    }
}
