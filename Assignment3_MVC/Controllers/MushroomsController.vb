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
    Public Class MushroomsController
        Inherits System.Web.Mvc.Controller

        Private db As New Agriculture_DatabaseEntities

        ' GET: Mushrooms
        Function Index() As ActionResult
            Dim mushrooms = db.Mushrooms.Include(Function(m) m.Vegetable)
            Return View(mushrooms.ToList())
        End Function

        ' GET: Mushrooms/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim mushroom As Mushroom = db.Mushrooms.Find(id)
            If IsNothing(mushroom) Then
                Return HttpNotFound()
            End If
            Return View(mushroom)
        End Function

        ' GET: Mushrooms/Create
        Function Create() As ActionResult
            ViewBag.Veg_ID = New SelectList(db.Vegetables, "Veg_ID", "Veg_Name")
            Return View()
        End Function

        ' POST: Mushrooms/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Form_ID,Veg_ID,Form,Average_Retail_Price_Dollars,Price_Unit,Preparation_yield_Factor,Size_Cup_Equivalent,Size_Unit,Average_Price_Per_Cup_Dollars")> ByVal mushroom As Mushroom) As ActionResult
            If ModelState.IsValid Then
                db.Mushrooms.Add(mushroom)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Veg_ID = New SelectList(db.Vegetables, "Veg_ID", "Veg_Name", mushroom.Veg_ID)
            Return View(mushroom)
        End Function

        ' GET: Mushrooms/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim mushroom As Mushroom = db.Mushrooms.Find(id)
            If IsNothing(mushroom) Then
                Return HttpNotFound()
            End If
            ViewBag.Veg_ID = New SelectList(db.Vegetables, "Veg_ID", "Veg_Name", mushroom.Veg_ID)
            Return View(mushroom)
        End Function

        ' POST: Mushrooms/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Form_ID,Veg_ID,Form,Average_Retail_Price_Dollars,Price_Unit,Preparation_yield_Factor,Size_Cup_Equivalent,Size_Unit,Average_Price_Per_Cup_Dollars")> ByVal mushroom As Mushroom) As ActionResult
            If ModelState.IsValid Then
                db.Entry(mushroom).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Veg_ID = New SelectList(db.Vegetables, "Veg_ID", "Veg_Name", mushroom.Veg_ID)
            Return View(mushroom)
        End Function

        ' GET: Mushrooms/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim mushroom As Mushroom = db.Mushrooms.Find(id)
            If IsNothing(mushroom) Then
                Return HttpNotFound()
            End If
            Return View(mushroom)
        End Function

        ' POST: Mushrooms/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim mushroom As Mushroom = db.Mushrooms.Find(id)
            db.Mushrooms.Remove(mushroom)
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
