Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Assignment3_MVC.Assignment3_MVC

Namespace Controllers
    Public Class PotatoesController
        Inherits System.Web.Mvc.Controller

        Private db As New Agriculture_DatabaseEntities

        ' GET: Potatoes
        Function Index() As ActionResult
            Dim potatoes = db.Potatoes.Include(Function(p) p.Vegetable)
            Return View(potatoes.ToList())
        End Function

        ' GET: Potatoes/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim potato As Potato = db.Potatoes.Find(id)
            If IsNothing(potato) Then
                Return HttpNotFound()
            End If
            Return View(potato)
        End Function

        ' GET: Potatoes/Create
        Function Create() As ActionResult
            ViewBag.Veg_ID = New SelectList(db.Vegetables, "Veg_ID", "Veg_Name")
            Return View()
        End Function

        ' POST: Potatoes/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Form_ID,Veg_ID,Form,Average_Retail_Price_Dollars,Price_Unit,Preparation_yield_Factor,Size_Cup_Equivalent,Size_Unit,Average_Price_Per_Cup_Dollars")> ByVal potato As Potato) As ActionResult
            If ModelState.IsValid Then
                db.Potatoes.Add(potato)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Veg_ID = New SelectList(db.Vegetables, "Veg_ID", "Veg_Name", potato.Veg_ID)
            Return View(potato)
        End Function

        ' GET: Potatoes/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim potato As Potato = db.Potatoes.Find(id)
            If IsNothing(potato) Then
                Return HttpNotFound()
            End If
            ViewBag.Veg_ID = New SelectList(db.Vegetables, "Veg_ID", "Veg_Name", potato.Veg_ID)
            Return View(potato)
        End Function

        ' POST: Potatoes/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Form_ID,Veg_ID,Form,Average_Retail_Price_Dollars,Price_Unit,Preparation_yield_Factor,Size_Cup_Equivalent,Size_Unit,Average_Price_Per_Cup_Dollars")> ByVal potato As Potato) As ActionResult
            If ModelState.IsValid Then
                db.Entry(potato).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Veg_ID = New SelectList(db.Vegetables, "Veg_ID", "Veg_Name", potato.Veg_ID)
            Return View(potato)
        End Function

        ' GET: Potatoes/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim potato As Potato = db.Potatoes.Find(id)
            If IsNothing(potato) Then
                Return HttpNotFound()
            End If
            Return View(potato)
        End Function

        ' POST: Potatoes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim potato As Potato = db.Potatoes.Find(id)
            db.Potatoes.Remove(potato)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
