<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Rentals Available</h1>
        <p class="lead">Looking for a new home. You&#39;ve found the right spot!</p>
		<p><a href="http://RentJaxHomes.com" class="btn btn-primary btn-lg">Current Listings &raquo;</a></p>
</div>

    <div class="row">
        <div class="col-md-4">
            <h2>Jacksonville Area</h2>
            <p>
                 Jacksonville is the largest city in the continental United States with over 840 square miles.
            Jacksonville is home to the country's largest urban park system with 111,669 acres of parks.
            </p>
            <p>
               <a class="btn btn-default" href="http://www.visitjacksonville.com/media/fast-facts/">Learn more &raquo;</a>     
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more Statistics About Jacksonville</h2>
            <p>
                 Jacksonville has a humid subtropical climate and has suffered less damage from hurricanes than most other east coast cities. The city has only received one 
				direct hit from a hurricane since 1871.
            </p>
            <p>
				<a class="btn btn-default" href="http://en.wikipedia.org/wiki/Jacksonville,_Florida">More Data &raquo;</a>             </p>
        </div>
        <div class="col-md-4">
            <h2>Rental Requirements</h2>
            <p>
                You can easily qualify for your new home..
            </p>
            <p>
				<a class="btn btn-default" href="http://www.freshfromflorida.com/Divisions-Offices/Consumer-Services/Consumer-Resources/Consumer-Protection/Publications/Landlord-Tenant-Law-in-Florida">Specifics &raquo;</a>

            </p>
        </div>
    </div>
</asp:Content>
