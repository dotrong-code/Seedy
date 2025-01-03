using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Seed.Domain.Entities;

namespace Seed.Infrastructure.DB.Configuration
{
    public class EmailTemplateConfiguration : IEntityTypeConfiguration<EmailTemplate>
    {
        public void Configure(EntityTypeBuilder<EmailTemplate> builder)
        {
            builder.HasData(
                 new EmailTemplate
                 {
                     EmailTemplateId = new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                     Subject = "Account Activation",
                     Body = @"
                <!DOCTYPE html>

<html lang=""en"" xmlns:o=""urn:schemas-microsoft-com:office:office"" xmlns:v=""urn:schemas-microsoft-com:vml"">
<head>
<title></title>
<meta content=""text/html; charset=utf-8"" http-equiv=""Content-Type""/>
<meta content=""width=device-width, initial-scale=1.0"" name=""viewport""/><!--[if mso]><xml><o:OfficeDocumentSettings><o:PixelsPerInch>96</o:PixelsPerInch><o:AllowPNG/></o:OfficeDocumentSettings></xml><![endif]--><!--[if !mso]><!-->
<link href=""https://fonts.googleapis.com/css2?family=Montserrat:wght@100;200;300;400;500;600;700;800;900"" rel=""stylesheet"" type=""text/css""/><!--<![endif]-->
<style>
		* {
			box-sizing: border-box;
		}

		body {
			margin: 0;
			padding: 0;
		}

		a[x-apple-data-detectors] {
			color: inherit !important;
			text-decoration: inherit !important;
		}

		#MessageViewBody a {
			color: inherit;
			text-decoration: none;
		}

		p {
			line-height: inherit
		}

		.desktop_hide,
		.desktop_hide table {
			mso-hide: all;
			display: none;
			max-height: 0px;
			overflow: hidden;
		}

		.image_block img+div {
			display: none;
		}

		sup,
		sub {
			font-size: 75%;
			line-height: 0;
		}

		@media (max-width:660px) {

			.desktop_hide table.icons-inner,
			.social_block.desktop_hide .social-table {
				display: inline-block !important;
			}

			.icons-inner {
				text-align: center;
			}

			.icons-inner td {
				margin: 0 auto;
			}

			.image_block div.fullWidth {
				max-width: 100% !important;
			}

			.mobile_hide {
				display: none;
			}

			.row-content {
				width: 100% !important;
			}

			.stack .column {
				width: 100%;
				display: block;
			}

			.mobile_hide {
				min-height: 0;
				max-height: 0;
				max-width: 0;
				overflow: hidden;
				font-size: 0px;
			}

			.desktop_hide,
			.desktop_hide table {
				display: table !important;
				max-height: none !important;
			}
		}
	</style><!--[if mso ]><style>sup, sub { font-size: 100% !important; } sup { mso-text-raise:10% } sub { mso-text-raise:-10% }</style> <![endif]-->
</head>
<body class=""body"" style=""background-color: #f8f8f9; margin: 0; padding: 0; -webkit-text-size-adjust: none; text-size-adjust: none;"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""nl-container"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f8f8f9;"" width=""100%"">
<tbody>
<tr>
<td>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row row-1"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #1aa19c;"" width=""100%"">
<tbody>
<tr>
<td>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row-content stack"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #1aa19c; color: #000000; width: 640px; margin: 0 auto;"" width=""640"">
<tbody>
<tr>
<td class=""column column-1"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;"" width=""100%"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_block block-1"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""pad"">
<div align=""center"" class=""alignment"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 4px solid #1AA19C;""><span style=""word-break: break-word;""> </span></td>
</tr>
</table>
</div>
</td>
</tr>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row row-2"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff;"" width=""100%"">
<tbody>
<tr>
<td>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row-content stack"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff; color: #000000; width: 640px; margin: 0 auto;"" width=""640"">
<tbody>
<tr>
<td class=""column column-1"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;"" width=""100%"">
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row row-3"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tbody>
<tr>
<td>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row-content stack"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f8f8f9; color: #000000; width: 640px; margin: 0 auto;"" width=""640"">
<tbody>
<tr>
<td class=""column column-1"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; padding-bottom: 5px; padding-top: 5px; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;"" width=""100%"">
<table border=""0"" cellpadding=""20"" cellspacing=""0"" class=""divider_block block-1"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""pad"">
<div align=""center"" class=""alignment"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;""><span style=""word-break: break-word;""> </span></td>
</tr>
</table>
</div>
</td>
</tr>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row row-4"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tbody>
<tr>
<td>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row-content stack"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff; color: #000000; width: 640px; margin: 0 auto;"" width=""640"">
<tbody>
<tr>
<td class=""column column-1"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;"" width=""100%"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_block block-1"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""pad"" style=""padding-bottom:12px;padding-top:60px;"">
<div align=""center"" class=""alignment"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;""><span style=""word-break: break-word;""> </span></td>
</tr>
</table>
</div>
</td>
</tr>
</table>
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""image_block block-2"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""pad"" style=""padding-left:40px;padding-right:40px;width:100%;"">
<div align=""center"" class=""alignment"" style=""line-height:10px"">
<div class=""fullWidth"" style=""max-width: 352px;""><img alt=""I'm an image"" height=""auto"" src=""{Img1_2x}"" style=""display: block; height: auto; border: 0; width: 100%;"" title=""I'm an image"" width=""352""/></div>
</div>
</td>
</tr>
</table>
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_block block-3"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""pad"" style=""padding-top:50px;"">
<div align=""center"" class=""alignment"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;""><span style=""word-break: break-word;""> </span></td>
</tr>
</table>
</div>
</td>
</tr>
</table>
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""paragraph_block block-4"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; word-break: break-word;"" width=""100%"">
	<tr>
	<td class=""pad"" style=""padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px;"">
	<div style=""color:#555555;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;font-size:30px;line-height:120%;text-align:center;mso-line-height-alt:36px;"">
	<p style=""margin: 0; word-break: break-word;""><span style=""word-break: break-word; color: #2b303a;""><strong>Verify Your Email Account</strong></span></p>
	</div>
	</td>
	</tr>
	</table>
	<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""paragraph_block block-5"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; word-break: break-word;"" width=""100%"">
	<tr>
	<td class=""pad"" style=""padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px;"">
	<div style=""color:#555555;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;font-size:15px;line-height:150%;text-align:center;mso-line-height-alt:22.5px;"">
	<p style=""margin: 0; word-break: break-word;"">
	<span style=""word-break: break-word; color: #808389;"">
	We're so glad you're here. To start accessing our Koi care services, please verify your email. It only takes a moment!
	</span>
	</p>
	<p style=""margin: 0; word-break: break-word;"">
	<span style=""word-break: break-word; color: #808389;"">
	Simply click the link below to confirm your email and unlock full access to our platform.
	</span>
	</p>
	</div>
	</td>
	</tr>
	</table>
	<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""button_block block-6"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
	<tr>
	<td class=""pad"" style=""padding-left:10px;padding-right:10px;padding-top:15px;text-align:center;"">
	<div align=""center"" class=""alignment""><!--[if mso]>
	<v:roundrect xmlns:v=""urn:schemas-microsoft-com:vml"" xmlns:w=""urn:schemas-microsoft-com:office:word"" style=""height:62px;width:222px;v-text-anchor:middle;"" arcsize=""97%"" stroke=""false"" fillcolor=""#1aa19c"">
	<w:anchorlock/>
	<v:textbox inset=""0px,0px,0px,0px"">
	<center dir=""false"" style=""color:#ffffff;font-family:Tahoma, sans-serif;font-size:16px"">
	<![endif]-->
	<div style=""background-color:#1aa19c;border-radius:60px;color:#ffffff;display:inline-block;font-family:Montserrat, sans-serif;font-size:16px;padding:15px 30px;text-align:center;text-decoration:none;"">
		<a href=""{VerifyURL}"" style=""color: #ffffff; text-decoration: none; display: inline-block; line-height: 32px;"">
			<strong>Confirm Your Email</strong>
		</a>
	</div>
	<!--[if mso]></center></v:textbox></v:roundrect><![endif]-->
	</div>
	</td>
	</tr>
	</table>
	
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_block block-7"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""pad"" style=""padding-bottom:12px;padding-top:60px;"">
<div align=""center"" class=""alignment"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;""><span style=""word-break: break-word;""> </span></td>
</tr>
</table>
</div>
</td>
</tr>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row row-5"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tbody>
<tr>
<td>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row-content stack"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f8f8f9; color: #000000; width: 640px; margin: 0 auto;"" width=""640"">
<tbody>
<tr>
<td class=""column column-1"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; padding-bottom: 5px; padding-top: 5px; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;"" width=""100%"">
<table border=""0"" cellpadding=""20"" cellspacing=""0"" class=""divider_block block-1"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""pad"">
<div align=""center"" class=""alignment"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;""><span style=""word-break: break-word;""> </span></td>
</tr>
</table>
</div>
</td>
</tr>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row row-6"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tbody>
<tr>
<td>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row-content stack"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #2b303a; color: #000000; width: 640px; margin: 0 auto;"" width=""640"">
<tbody>
<tr>
<td class=""column column-1"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;"" width=""100%"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_block block-1"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""pad"">
<div align=""center"" class=""alignment"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 4px solid #1AA19C;""><span style=""word-break: break-word;""> </span></td>
</tr>
</table>
</div>
</td>
</tr>
</table>
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""image_block block-2"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""pad"" style=""width:100%;"">
<div align=""center"" class=""alignment"" style=""line-height:10px"">
<div style=""max-width: 640px;""><img alt=""I'm an image"" height=""auto"" src=""{footer}"" style=""display: block; height: auto; border: 0; width: 100%;"" title=""I'm an image"" width=""640""/></div>
</div>
</td>
</tr>
</table>
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""social_block block-4"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""pad"" style=""padding-bottom:10px;padding-left:10px;padding-right:10px;padding-top:28px;text-align:center;"">
<div align=""center"" class=""alignment"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""social-table"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; display: inline-block;"" width=""208px"">
<tr>
<td style=""padding:0 10px 0 10px;""><a href=""https://www.facebook.com"" target=""_blank""><img alt=""Facebook"" height=""auto"" src=""{facebook2x}"" style=""display: block; height: auto; border: 0;"" title=""Facebook"" width=""32""/></a></td>
<td style=""padding:0 10px 0 10px;""><a href=""https://www.twitter.com"" target=""_blank""><img alt=""Twitter"" height=""auto"" src=""{twitter2x}"" style=""display: block; height: auto; border: 0;"" title=""Twitter"" width=""32""/></a></td>
<td style=""padding:0 10px 0 10px;""><a href=""https://www.instagram.com"" target=""_blank""><img alt=""Instagram"" height=""auto"" src=""{instagram2x}"" style=""display: block; height: auto; border: 0;"" title=""Instagram"" width=""32""/></a></td>
<td style=""padding:0 10px 0 10px;""><a href=""https://www.linkedin.com"" target=""_blank""><img alt=""LinkedIn"" height=""auto"" src=""{linkedin2x}"" style=""display: block; height: auto; border: 0;"" title=""LinkedIn"" width=""32""/></a></td>
</tr>
</table>
</div>
</td>
</tr>
</table>
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_block block-6"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""pad"" style=""padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:25px;"">
<div align=""center"" class=""alignment"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 1px solid #555961;""><span style=""word-break: break-word;""> </span></td>
</tr>
</table>
</div>
</td>
</tr>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row row-7"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #ffffff;"" width=""100%"">
<tbody>
<tr>
<td>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row-content stack"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #ffffff; color: #000000; width: 640px; margin: 0 auto;"" width=""640"">
<tbody>
<tr>
<td class=""column column-1"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; padding-bottom: 5px; padding-top: 5px; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;"" width=""100%"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""icons_block block-1"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; text-align: center; line-height: 0;"" width=""100%"">
<tr>
<td class=""pad"" style=""vertical-align: middle; color: #1e0e4b; font-family: 'Inter', sans-serif; font-size: 15px; padding-bottom: 5px; padding-top: 5px; text-align: center;""><!--[if vml]><table align=""center"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""display:inline-block;padding-left:0px;padding-right:0px;mso-table-lspace: 0pt;mso-table-rspace: 0pt;""><![endif]-->
<!--[if !vml]><!-->
</td>
</tr>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table><!-- End -->
</body>
</html>",
                     Type = "VerifyEmail",
                     IsDelete = false,
                     CreateDate = DateTime.Now,
                     CreateBy = "System",
                     UpdateDate = DateTime.Now,
                     UpdateBy = "System",
                     ImageMappingsJson = "{\"facebook2x\":\"EmailTemplate/e1fbe444-69f1-43f1-ac5a-5ce3e42a1e05_facebook2x.png\",\"footer\":\"EmailTemplate/305d75fc-b361-464e-937e-a495da6e4040_footer.png\",\"Img1_2x\":\"EmailTemplate/3b589f60-80a7-482c-9190-671f68b4a072_Img1_2x.jpg\",\"instagram2x\":\"EmailTemplate/39dd2a42-10b4-4449-a17e-cc5652ca7866_instagram2x.png\",\"linkedin2x\":\"EmailTemplate/54a2a542-a077-4d05-9c7a-e04c5335bf4d_linkedin2x.png\",\"twitter2x\":\"EmailTemplate/2564da8a-64ff-4fab-956e-dc0dd15c3b02_twitter2x.png\"}"
                 },
                new EmailTemplate
                {
                    EmailTemplateId = new Guid("b4a72a2f-77b9-4fa7-8a87-bb1ef61f2446"),
                    Subject = "Appointment Booking Notification",
                    Body = @"
                <!DOCTYPE html>

<html lang=""en"" xmlns:o=""urn:schemas-microsoft-com:office:office"" xmlns:v=""urn:schemas-microsoft-com:vml"">
<head>
<title></title>
<meta content=""text/html; charset=utf-8"" http-equiv=""Content-Type""/>
<meta content=""width=device-width, initial-scale=1.0"" name=""viewport""/><!--[if mso]><xml><o:OfficeDocumentSettings><o:PixelsPerInch>96</o:PixelsPerInch><o:AllowPNG/></o:OfficeDocumentSettings></xml><![endif]--><!--[if !mso]><!-->
<link href=""https://fonts.googleapis.com/css2?family=Montserrat:wght@100;200;300;400;500;600;700;800;900"" rel=""stylesheet"" type=""text/css""/><!--<![endif]-->
<style>
		* {
			box-sizing: border-box;
		}

		body {
			margin: 0;
			padding: 0;
		}

		a[x-apple-data-detectors] {
			color: inherit !important;
			text-decoration: inherit !important;
		}

		#MessageViewBody a {
			color: inherit;
			text-decoration: none;
		}

		p {
			line-height: inherit
		}

		.desktop_hide,
		.desktop_hide table {
			mso-hide: all;
			display: none;
			max-height: 0px;
			overflow: hidden;
		}

		.image_block img+div {
			display: none;
		}

		sup,
		sub {
			font-size: 75%;
			line-height: 0;
		}

		@media (max-width:660px) {

			.desktop_hide table.icons-inner,
			.social_block.desktop_hide .social-table {
				display: inline-block !important;
			}

			.icons-inner {
				text-align: center;
			}

			.icons-inner td {
				margin: 0 auto;
			}

			.image_block div.fullWidth {
				max-width: 100% !important;
			}

			.mobile_hide {
				display: none;
			}

			.row-content {
				width: 100% !important;
			}

			.stack .column {
				width: 100%;
				display: block;
			}

			.mobile_hide {
				min-height: 0;
				max-height: 0;
				max-width: 0;
				overflow: hidden;
				font-size: 0px;
			}

			.desktop_hide,
			.desktop_hide table {
				display: table !important;
				max-height: none !important;
			}
		}
	</style><!--[if mso ]><style>sup, sub { font-size: 100% !important; } sup { mso-text-raise:10% } sub { mso-text-raise:-10% }</style> <![endif]-->
</head>
<body class=""body"" style=""background-color: #f8f8f9; margin: 0; padding: 0; -webkit-text-size-adjust: none; text-size-adjust: none;"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""nl-container"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f8f8f9;"" width=""100%"">
<tbody>
<tr>
<td>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row row-1"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #1aa19c;"" width=""100%"">
<tbody>
<tr>
<td>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row-content stack"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #1aa19c; color: #000000; width: 640px; margin: 0 auto;"" width=""640"">
<tbody>
<tr>
<td class=""column column-1"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;"" width=""100%"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_block block-1"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""pad"">
<div align=""center"" class=""alignment"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 4px solid #1AA19C;""><span style=""word-break: break-word;""> </span></td>
</tr>
</table>
</div>
</td>
</tr>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row row-2"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff;"" width=""100%"">
<tbody>
<tr>
<td>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row-content stack"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff; color: #000000; width: 640px; margin: 0 auto;"" width=""640"">
<tbody>
<tr>
<td class=""column column-1"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;"" width=""100%"">
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row row-3"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tbody>
<tr>
<td>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row-content stack"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f8f8f9; color: #000000; width: 640px; margin: 0 auto;"" width=""640"">
<tbody>
<tr>
<td class=""column column-1"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; padding-bottom: 5px; padding-top: 5px; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;"" width=""100%"">
<table border=""0"" cellpadding=""20"" cellspacing=""0"" class=""divider_block block-1"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""pad"">
<div align=""center"" class=""alignment"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;""><span style=""word-break: break-word;""> </span></td>
</tr>
</table>
</div>
</td>
</tr>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row row-4"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tbody>
<tr>
<td>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row-content stack"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff; color: #000000; width: 640px; margin: 0 auto;"" width=""640"">
<tbody>
<tr>
	<td class=""column column-1"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;"" width=""100%"">
		<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_block block-1"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
			<tr>
				<td class=""pad"" style=""padding-bottom:12px;padding-top:60px;"">
					<div align=""center"" class=""alignment"">
						<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
							<tr>
								<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;""><span style=""word-break: break-word;""> </span></td>
							</tr>
						</table>
					</div>
				</td>
			</tr>
		</table>
		<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""image_block block-2"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
			<tr>
				<td class=""pad"" style=""padding-left:40px;padding-right:40px;width:100%;"">
					<div align=""center"" class=""alignment"" style=""line-height:10px"">
						<div class=""fullWidth"" style=""max-width: 352px;""><img alt=""I'm an image"" height=""auto"" src=""{Img1_2x}"" style=""display: block; height: auto; border: 0; width: 100%;"" title=""I'm an image"" width=""352"" /></div>
					</div>
				</td>
			</tr>
		</table>
		<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_block block-3"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
			<tr>
				<td class=""pad"" style=""padding-top:50px;"">
					<div align=""center"" class=""alignment"">
						<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
							<tr>
								<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;""><span style=""word-break: break-word;""> </span></td>
							</tr>
						</table>
					</div>
				</td>
			</tr>
		</table>
		<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""paragraph_block block-4"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; word-break: break-word;"" width=""100%"">
			<tr>
				<td class=""pad"" style=""padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px;"">
					<div style=""color:#555555;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;font-size:30px;line-height:120%;text-align:center;mso-line-height-alt:36px;"">
						<p style=""margin: 0; word-break: break-word;""><span style=""word-break: break-word; color: #2b303a;""><strong>Appointment Confirmation</strong></span></p>
					</div>
				</td>
			</tr>
		</table>

		<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""paragraph_block block-5"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; word-break: break-word;"" width=""100%"">
			<tr>
				<td class=""pad"" style=""padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px;"">
					<div style=""color:#555555;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;font-size:15px;line-height:150%;text-align:center;mso-line-height-alt:22.5px;"">
						<p style=""margin: 0; word-break: break-word;"">
							<span style=""word-break: break-word; color: #808389;"">
								Hello {Name},
							</span>
						</p>
						<p style=""margin: 0; word-break: break-word;"">
							<span style=""word-break: break-word; color: #808389;"">
								We’re confirming your appointment with us for our Koi care service. Please review the details below and click the button to view the appointment information.
							</span>
						</p>
					</div>
				</td>
			</tr>
		</table>

		<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""paragraph_block block-6"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; word-break: break-word;"" width=""100%"">
			<tr>
				<td class=""pad"" style=""padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px;"">
					<div style=""color:#555555;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;font-size:15px;line-height:150%;text-align:left;mso-line-height-alt:22.5px;"">
						<p style=""margin: 0; word-break: break-word;"">
							<span style=""word-break: break-word; color: #808389;""><strong>Appointment Date:</strong> {AppointmentDate}</span>
						</p>
						<p style=""margin: 0; word-break: break-word;"">
							<span style=""word-break: break-word; color: #808389;""><strong>Time:</strong> {AppointmentTime}</span>
						</p>
						<p style=""margin: 0; word-break: break-word;"">
							<span style=""word-break: break-word; color: #808389;""><strong>Service:</strong> {ServiceName}</span>
						</p>
						<p style=""margin: 0; word-break: break-word;"">
							<span style=""word-break: break-word; color: #808389;""><strong>Pet:</strong> {PetName}</span>
						</p>
					</div>
				</td>
			</tr>
		</table>

		<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""button_block block-7"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
			<tr>
				<td class=""pad"" style=""padding-left:10px;padding-right:10px;padding-top:15px;text-align:center;"">
					<div align=""center"" class=""alignment"">
						<!--[if mso]>
					<v:roundrect xmlns:v=""urn:schemas-microsoft-com:vml"" xmlns:w=""urn:schemas-microsoft-com:office:word"" style=""height:62px;width:222px;v-text-anchor:middle;"" arcsize=""97%"" stroke=""false"" fillcolor=""#1aa19c"">
					<w:anchorlock/>
					<v:textbox inset=""0px,0px,0px,0px"">
					<center dir=""false"" style=""color:#ffffff;font-family:Tahoma, sans-serif;font-size:16px"">
					<![endif]-->
						<div style=""background-color:#1aa19c;border-radius:60px;color:#ffffff;display:inline-block;font-family:Montserrat, sans-serif;font-size:16px;padding:15px 30px;text-align:center;text-decoration:none;"">
							<a href=""{AppointmentDetailURL}"" style=""color: #ffffff; text-decoration: none; display: inline-block; line-height: 32px;"">
								<strong>View Appointment Details</strong>
							</a>
						</div>
						<!--[if mso]></center></v:textbox></v:roundrect><![endif]-->
					</div>
				</td>
			</tr>
		</table>

		<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_block block-8"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
			<tr>
				<td class=""pad"" style=""padding-bottom:12px;padding-top:60px;"">
					<div align=""center"" class=""alignment"">
						<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
							<tr>
								<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;""><span style=""word-break: break-word;""> </span></td>
							</tr>
						</table>
					</div>
				</td>
			</tr>
		</table>


		<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_block block-7"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
			<tr>
				<td class=""pad"" style=""padding-bottom:12px;padding-top:60px;"">
					<div align=""center"" class=""alignment"">
						<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
							<tr>
								<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;""><span style=""word-break: break-word;""> </span></td>
							</tr>
						</table>
					</div>
				</td>
			</tr>
		</table>
	</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row row-5"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tbody>
<tr>
<td>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row-content stack"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f8f8f9; color: #000000; width: 640px; margin: 0 auto;"" width=""640"">
<tbody>
<tr>
<td class=""column column-1"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; padding-bottom: 5px; padding-top: 5px; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;"" width=""100%"">
<table border=""0"" cellpadding=""20"" cellspacing=""0"" class=""divider_block block-1"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""pad"">
<div align=""center"" class=""alignment"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;""><span style=""word-break: break-word;""> </span></td>
</tr>
</table>
</div>
</td>
</tr>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row row-6"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tbody>
<tr>
<td>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row-content stack"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #2b303a; color: #000000; width: 640px; margin: 0 auto;"" width=""640"">
<tbody>
<tr>
<td class=""column column-1"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;"" width=""100%"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_block block-1"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""pad"">
<div align=""center"" class=""alignment"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 4px solid #1AA19C;""><span style=""word-break: break-word;""> </span></td>
</tr>
</table>
</div>
</td>
</tr>
</table>
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""image_block block-2"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""pad"" style=""width:100%;"">
<div align=""center"" class=""alignment"" style=""line-height:10px"">
<div style=""max-width: 640px;""><img alt=""I'm an image"" height=""auto"" src=""{footer}"" style=""display: block; height: auto; border: 0; width: 100%;"" title=""I'm an image"" width=""640""/></div>
</div>
</td>
</tr>
</table>
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""social_block block-4"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""pad"" style=""padding-bottom:10px;padding-left:10px;padding-right:10px;padding-top:28px;text-align:center;"">
<div align=""center"" class=""alignment"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""social-table"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; display: inline-block;"" width=""208px"">
<tr>
<td style=""padding:0 10px 0 10px;""><a href=""https://www.facebook.com"" target=""_blank""><img alt=""Facebook"" height=""auto"" src=""{facebook2x}"" style=""display: block; height: auto; border: 0;"" title=""Facebook"" width=""32""/></a></td>
<td style=""padding:0 10px 0 10px;""><a href=""https://www.twitter.com"" target=""_blank""><img alt=""Twitter"" height=""auto"" src=""{twitter2x}"" style=""display: block; height: auto; border: 0;"" title=""Twitter"" width=""32""/></a></td>
<td style=""padding:0 10px 0 10px;""><a href=""https://www.instagram.com"" target=""_blank""><img alt=""Instagram"" height=""auto"" src=""{instagram2x}"" style=""display: block; height: auto; border: 0;"" title=""Instagram"" width=""32""/></a></td>
<td style=""padding:0 10px 0 10px;""><a href=""https://www.linkedin.com"" target=""_blank""><img alt=""LinkedIn"" height=""auto"" src=""{linkedin2x}"" style=""display: block; height: auto; border: 0;"" title=""LinkedIn"" width=""32""/></a></td>
</tr>
</table>
</div>
</td>
</tr>
</table>
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_block block-6"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""pad"" style=""padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:25px;"">
<div align=""center"" class=""alignment"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" width=""100%"">
<tr>
<td class=""divider_inner"" style=""font-size: 1px; line-height: 1px; border-top: 1px solid #555961;""><span style=""word-break: break-word;""> </span></td>
</tr>
</table>
</div>
</td>
</tr>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row row-7"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #ffffff;"" width=""100%"">
<tbody>
<tr>
<td>
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""row-content stack"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #ffffff; color: #000000; width: 640px; margin: 0 auto;"" width=""640"">
<tbody>
<tr>
<td class=""column column-1"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; padding-bottom: 5px; padding-top: 5px; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;"" width=""100%"">
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""icons_block block-1"" role=""presentation"" style=""mso-table-lspace: 0pt; mso-table-rspace: 0pt; text-align: center; line-height: 0;"" width=""100%"">
<tr>
<td class=""pad"" style=""vertical-align: middle; color: #1e0e4b; font-family: 'Inter', sans-serif; font-size: 15px; padding-bottom: 5px; padding-top: 5px; text-align: center;""><!--[if vml]><table align=""center"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""display:inline-block;padding-left:0px;padding-right:0px;mso-table-lspace: 0pt;mso-table-rspace: 0pt;""><![endif]-->
<!--[if !vml]><!-->
</td>
</tr>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table><!-- End -->
</body>
</html>",
                    Type = "MakeAppointment",
                    IsDelete = false,
                    CreateDate = DateTime.Now,
                    CreateBy = "System",
                    UpdateDate = DateTime.Now,
                    UpdateBy = "System",
                    ImageMappingsJson = "{\"facebook2x\":\"EmailTemplate/c387781f-57b2-4daa-8dbb-74ae478b3527_facebook2x.png\",\"footer\":\"EmailTemplate/8d6faaac-8b6f-4ec9-a169-af2c3fdf0a1f_footer.png\",\"Img1_2x\":\"EmailTemplate/63acd16b-f91d-4158-957d-a0f873fd9bd0_Img1_2x.png\",\"instagram2x\":\"EmailTemplate/b0c0fa7e-ee9b-45d7-a804-07f37d96008b_instagram2x.png\",\"linkedin2x\":\"EmailTemplate/202c8e61-533b-4ffb-9639-a038de869c0c_linkedin2x.png\",\"twitter2x\":\"EmailTemplate/e576f46a-a7de-4ad3-81dd-7297fbde391d_twitter2x.png\"}"
                },
                new EmailTemplate
                {
                    EmailTemplateId = new Guid("fe241b67-9fb5-49d4-94ec-7801a8e71e9a"),
                    Subject = "Your Password Has Been Reset",
                    Body = @"
                <html>
                <body>
                    <p>Hello {{UserName}},</p>
                    <p>Your password has been successfully reset. You can now log in with your new password.</p>
                    <p>If you did not request this change, please contact our support team immediately.</p>
                    <p>Best regards,<br>Koi Veterinary Service Center</p>
                </body>
                </html>",
                    Type = "ResetPassword",
                    IsDelete = false,
                    CreateDate = DateTime.Now,
                    CreateBy = "System",
                    UpdateDate = DateTime.Now,
                    UpdateBy = "System"
                },
                new EmailTemplate
                {
                    EmailTemplateId = new Guid("e42c3d1a-2e1c-4b2a-92f2-33d1cf2fdc2b"),
                    Subject = "Account Confirmation",
                    Body = @"
                <html>
                <body>
                    <p>Hello {{UserName}},</p>
                    <p>Thank you for registering with the Koi Veterinary Service Center. Please confirm your account by clicking the link below:</p>
                    <p><a href='{{ConfirmationLink}}'>Confirm Account</a></p>
                    <p>If you did not register, please ignore this email.</p>
                    <p>Best regards,<br>Koi Veterinary Service Center</p>
                </body>
                </html>",
                    Type = "ConfirmationAccount",
                    IsDelete = false,
                    CreateDate = DateTime.Now,
                    CreateBy = "System",
                    UpdateDate = DateTime.Now,
                    UpdateBy = "System"
                },
                new EmailTemplate
                {
                    EmailTemplateId = new Guid("c2f45678-1a3d-4012-b4c1-234d5d7f8cde"),
                    Subject = "Appointment Rejection Notification",
                    Body = @"
                <html>
                <body>
                    <p>Hello {{UserName}},</p>
                    <p>We regret to inform you that your appointment for koi services has been rejected for the following reason:</p>
                    <p>{{RejectionReason}}</p>
                    <p>Best regards,<br>Koi Veterinary Service Center</p>
                </body>
                </html>",
                    Type = "RejectAppointment",
                    IsDelete = false,
                    CreateDate = DateTime.Now,
                    CreateBy = "System",
                    UpdateDate = DateTime.Now,
                    UpdateBy = "System"
                },
                new EmailTemplate
                {
                    EmailTemplateId = new Guid("94e2d05c-fbf9-4f1f-bf89-d2298f8b6b4b"),
                    Subject = "Appointment Approval Notification",
                    Body = @"
                <html>
                <body>
                    <p>Hello {{UserName}},</p>
                    <p>We are pleased to inform you that your appointment for koi fish care has been approved.</p>
                    <p>Best regards,<br>Koi Veterinary Service Center</p>
                </body>
                </html>",
                    Type = "ApproveAppointment",
                    IsDelete = false,
                    CreateDate = DateTime.Now,
                    CreateBy = "System",
                    UpdateDate = DateTime.Now,
                    UpdateBy = "System"
                },
                new EmailTemplate
                {
                    EmailTemplateId = new Guid("ef3455b2-3a6e-4cb5-9c6d-a432d9f1c7ab"),
                    Subject = "Ac",
                    Body = @"
                <html>
                <body>
                    <p>Hello {{UserName}},</p>
                    <p>Your account has been successfully activated. You can now log in and start using our koi veterinary services.</p>
                    <p>Best regards,<br>Koi Veterinary Service Center</p>
                </body>
                </html>",
                    Type = "ActivateUser",
                    IsDelete = false,
                    CreateDate = DateTime.Now,
                    CreateBy = "System",
                    UpdateDate = DateTime.Now,
                    UpdateBy = "System"
                },
                new EmailTemplate
                {
                    EmailTemplateId = new Guid("46db13e8-7899-432b-ae8c-febc15d0f1b2"),
                    Subject = "Account Deactivation",
                    Body = @"
                <html>
                <body>
                    <p>Hello {{UserName}},</p>
                    <p>Your account has been deactivated. If you think this is a mistake, please contact our support team.</p>
                    <p>Best regards,<br>Koi Veterinary Service Center</p>
                </body>
                </html>",
                    Type = "DeactivateUser",
                    IsDelete = false,
                    CreateDate = DateTime.Now,
                    CreateBy = "System",
                    UpdateDate = DateTime.Now,
                    UpdateBy = "System"
                },
                 new EmailTemplate
                 {
                     EmailTemplateId = new Guid("f1d7a678-87b5-4c12-b5f2-ae9e4a3d9b8a"),
                     Subject = "Service Update Notification",
                     Body = @"
                <html>
                <body>
                    <p>Dear {{UserName}},</p>
                    <p>Your requested koi service titled '{{ServiceTitle}}' has been successfully updated.</p>
                    <p>If you have any questions or need further assistance, please feel free to reach out to us.</p>
                    <p>Best regards,<br>Koi Veterinary Service Center</p>
                </body>
                </html>",
                     Type = "UpdateService",
                     IsDelete = false,
                     CreateDate = DateTime.Now,
                     CreateBy = "System",
                     UpdateDate = DateTime.Now,
                     UpdateBy = "System"
                 },
                  new EmailTemplate
                  {
                      EmailTemplateId = new Guid("1f7d6a3c-523d-44b6-b9c5-6f3d3c9874f1"),
                      Subject = "Service Deactivation Notification",
                      Body = @"
                <html>
                <body>
                    <p>Hello {{UserName}},</p>
                    <p>Your service titled '{{ServiceTitle}}' has been deactivated for the following reason:</p>
                    <p>{{DeactivationReason}}</p>
                    <p>Best regards,<br>Koi Veterinary Service Center</p>
                </body>
                </html>",
                      Type = "DeactivateService",
                      IsDelete = false,
                      CreateDate = DateTime.Now,
                      CreateBy = "System",
                      UpdateDate = DateTime.Now,
                      UpdateBy = "System"
                  }
            );
        }
    }
}
