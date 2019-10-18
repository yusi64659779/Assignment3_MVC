@ModelType Assignment3_MVC.Assignment3_MVC.Agri_Products
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Agri_Products</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Product_Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Product_Name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Product_ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
