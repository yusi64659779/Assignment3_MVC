@ModelType Assignment3_MVC.Assignment3_MVC.Fruit
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Fruit</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Fruit_Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Fruit_Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Agri_Products.Product_Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Agri_Products.Product_Name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With {.id = Model.Fruit_ID}) |
    @Html.ActionLink("Back to List", "Index")|
</p>
