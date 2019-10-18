@ModelType Assignment3_MVC.Assignment3_MVC.Apricot
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Apricot</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Form)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Form)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Average_Retail_Price_Dollars)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Average_Retail_Price_Dollars)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Price_Unit)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Price_Unit)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Preparation_yield_Factor)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Preparation_yield_Factor)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Size_Cup_Equivalent)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Size_Cup_Equivalent)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Size_Unit)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Size_Unit)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Average_Price_Per_Cup_Dollars)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Average_Price_Per_Cup_Dollars)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Fruit.Fruit_Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Fruit.Fruit_Name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Form_ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
