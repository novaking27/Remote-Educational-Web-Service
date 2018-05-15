<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="RemoteEducationalServicesWebApplication._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<style>
		.centre {
			margin: 0;
			position: absolute;
			top: 50%;
			left: 50%;
			margin-right: -50%;
			transform: translate(-50%, -50%)
		}

		body {
		color: #4e4e4e;
        background-image:url('background.jpg');
		/*background="background.jpg";*/
        font-family: 'Roboto', sans-serif;
       
	}
	.form-control {
		font-size: 16px;
		background: #f2f2f2;
		box-shadow: none !important;
		border-color: transparent;
	}
	.form-control:focus {
		border-color: #d3d3d3;
	}
	.form-control, .btn {        
		border-radius: 2px;
	}
	.login-form {
		width: 380px;
		margin: 0 auto;
	}
	.login-form h2 {		
		margin: 0;
		padding: 30px 0;
		font-size: 34px;
	}
	.login-form .avatar {
		margin: 0 auto 30px;
		width: 100px;
		height: 100px;
		border-radius: 50%;
		z-index: 9;
		background: #ef3b3a;
		padding: 15px;
		box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.1);
	}
	.login-form .avatar img {
		width: 100%;
	}
	.login-form form {
		color: #7a7a7a;
		border-radius: 4px;
		margin-bottom: 15px;
		background: #fff;
		box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.3);
		padding: 30px;		
	}	
	.login-form .btn {
		font-weight: bold;
		background: #ef3b3a;
		border: none;
		margin-bottom: 20px;
	}
	.login-form .btn:hover, .login-form .btn:focus {
		background: #ed2121;
		outline: none !important;
	}
	.login-form a {
		color: #ef3b3a;
	}	
	.login-form form a {
		color: #ef3b3a;
	}
	.login-form a:hover, .login-form form a:hover {
		text-decoration: underline;
	}
	.hint-text {
		color: #999;
		text-align: center;
	}
	.form-footer {
		padding-bottom: 15px;
		text-align: center;
	}
	</style>
	<!-- Latest compiled and minified CSS -->
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">

	<!-- jQuery library -->
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>

	<!-- Latest compiled JavaScript -->
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
   
	<form id="form1" runat="server"  class="centre">
         <!--  <asp:Login ID="ctlLogin" runat="server" OnAuthenticate="ctlLogin_Authenticate"/> -->
         <asp:Button ID="btncreate" runat="server" Text="Create master user" OnClick="btncreate_Click" /> 
		<div class="login-form">
			
					<img runat="server" src="~/images/Remote Educational Services logo.png" alt="logo" style="width: 380px;" />
			   
				
				<div class="form-group">
					<asp:TextBox runat="server" ID="txtUser" class="form-control input-lg" name="username" placeholder="Username" required="required" />
				</div>
				<div class="form-group">
					 <asp:TextBox ID="txtPass" runat="server" TextMode="Password"  class="form-control input-lg" name="password" placeholder="Password" required="required"/>
				</div>

				<div class="form-group">
					<asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" class="btn btn-primary btn-lg btn-block login-btn" />
					<asp:Label ID="lblStatus" runat="server" />
				</div>
		</div>
	</form>
</body>
</html>
