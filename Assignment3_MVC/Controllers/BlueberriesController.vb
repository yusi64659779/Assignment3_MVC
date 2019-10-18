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
    Public Class BlueberriesController
        Inherits System.Web.Mvc.Controller

        Private db As New Agriculture_DatabaseEntities

        ' GET: Blueberries
        Function Index() As ActionResult
            Dim blueberries = db.Blueberries.Include(Function(b) b.Fruit)
            Return View(blueberries.ToList())
        End Function

        ' GET: Blueberries/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim blueberry As Blueberry = db.Blueberries.Find(id)
            If IsNothing(blueberry) Then
                Return HttpNotFound()
            End If
            Return View(blueberry)
        End Function

        ' GET: Blueberries/Create
        Function Create() As ActionResult
            ViewBag.Fruit_ID = New SelectList(db.Fruits, "Fruit_ID", "Fruit_Name")
            Return View()
        End Function

        ' POST: Blueberries/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Form_ID,Fruit_ID,Form,Average_Retail_Price_Dollars,Price_Unit,Preparation_yield_Factor,Size_Cup_Equivalent,Size_Unit,Average_Price_Per_Cup_Dollars")> ByVal blueberry As Blueberry) As ActionResult
            If ModelState.IsValid Then
                db.Blueberries.Add(blueberry)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Fruit_ID = New SelectList(db.Fruits, "Fruit_ID", "Fruit_Name", blueberry.Fruit_ID)
            Return View(blueberry)
        End Function

        ' GET: Blueberries/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim blueberry As Blueberry = db.Blueberries.Find(id)
            If IsNothing(blueberry) Then
                Return HttpNotFound()
            End If
            ViewBag.Fruit_ID = New SelectList(db.Fruits, "Fruit_ID", "Fruit_Name", blueberry.Fruit_ID)
            Return View(blueberry)
        End Function

        ' POST: Blueberries/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Form_ID,Fruit_ID,Form,Average_Retail_Price_Dollars,Price_Unit,Preparation_yield_Factor,Size_Cup_Equivalent,Size_Unit,Average_Price_Per_Cup_Dollars")> ByVal blueberry As Blueberry) As ActionResult
            If ModelState.IsValid Then
                db.Entry(blueberry).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Fruit_ID = New SelectList(db.Fruits, "Fruit_ID", "Fruit_Name", blueberry.Fruit_ID)
            Return View(blueberry)
        End Function

        ' GET: Blueberries/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim blueberry As Blueberry = db.Blueberries.Find(id)
            If IsNothing(blueberry) Then
                Return HttpNotFound()
            End If
            Return View(blueberry)
        End Function

        ' POST: Blueberries/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim blueberry As Blueberry = db.Blueberries.Find(id)
            db.Blueberries.Remove(blueberry)
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
