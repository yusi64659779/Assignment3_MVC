@Code
    ViewData("Title") = "Home Page"
End Code

<div class="jumbotron">
    <h1>Agricultural Products</h1>
    <p class="lead">In this website, you will get the price details of fruits and vegetables</p>
</div>



<div class="row">
    <div class="col-md-4">
        <h2>Fruits</h2>
        @Html.ActionLink("Types of Fruits", "Index", "Fruits")
        <img src="~/Views/Home/Fruits.gif" alt="Friuts"/>
    </div>
    <div class="col-md-4">
        <h2>Vegetables</h2> 
        @Html.ActionLink("Types of Vegetables", "Index", "Vegetables")
    </div>
</div>
