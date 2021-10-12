import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

import { Observable } from 'rxjs';

import { Order } from '../order';
import { OrderService } from '../order.service';

import { MatSnackBar, MatSnackBarHorizontalPosition, MatSnackBarVerticalPosition } from '@angular/material/snack-bar';
import { MatDialog } from '@angular/material/dialog';
import { MatTableDataSource, } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';

import { SelectionModel } from '@angular/cdk/collections';

interface Shippers {
  ShipperId: number;
  CompanyName: string;
  Phone: string;
}

@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css']
})

export class OrderComponent implements OnInit { 

  ShipName!: string;
  ShippedDate!: Date;
  ShipVia!: string;
  Address!: string;
  City!: string;
  Country!: string;
  
  dataSaved = false;
  orderForm: FormGroup  = new FormGroup({});
  allOrders!: Observable<Order[]>;
  dataSource!: MatTableDataSource<Order>;
  selection = new SelectionModel<Order>(true, []);
  orderIdUpdate! : null;
  message = null;
  allShippers!: Observable<Shippers[]>;
  ShipperId = '';
  SelectedDate = null;
  horizontalPosition: MatSnackBarHorizontalPosition = 'center';
  verticalPosition: MatSnackBarVerticalPosition = 'bottom';
  displayedColumns: string[] = ['Id', 'ShippedDate', 'ShipVia', 'ShipName', 'Address', 'City', 'Country', 'Edit', 'Delete'];
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  submitted: boolean = false;

  constructor(private formbulider: FormBuilder, private orderService: OrderService, private _snackBar: MatSnackBar, public dialog: MatDialog) {
    this.orderService.getAllOrders().subscribe(data => {
      this.dataSource = new MatTableDataSource(data);
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;
    });
  }

  ngOnInit() {
    this.orderForm = new FormGroup({
      ShippedDate: new FormControl ('', [Validators.required]),
      ShipVia: new FormControl ('', [Validators.required]),
      ShipName: new FormControl ('', [Validators.required, Validators.maxLength(40), Validators.minLength(3)]),
      Address: new FormControl ('', [Validators.required, Validators.maxLength(60), Validators.minLength(3)]),
      City: new FormControl ('', [Validators.required, Validators.maxLength(15), Validators.minLength(3)]),
      Country: new FormControl ('', [Validators.required, Validators.maxLength(15), Validators.minLength(3)])
    });
    this.FillShippersDDL();
    this.LoadAllOrders();
    this.orderService.getAllOrders().subscribe(data => {
      this.dataSource = new MatTableDataSource(data);
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;  
    });
  }
  
  LoadAllOrders() {
    this.orderService.getAllOrders().subscribe(data => {
      this.dataSource = new MatTableDataSource(data);
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;
    });
  }

  onFormSubmit() {
    this.submitted = true;
    this.dataSaved = false;
    const order = this.orderForm.value;
    this.CreateOrder(order);
    this.orderForm.reset();
  }

  EditOrder(id: number) {
    this.orderService.getOrderById(id).subscribe(order => {
      this.message = null;
      this.dataSaved = false;
      this.orderIdUpdate = order.Id;
      this.orderForm.controls['ShippedDate'].setValue(order.ShippedDate);
      this.orderForm.controls['ShipVia'].setValue(order.ShipVia);
      this.orderForm.controls['ShipName'].setValue(order.ShipName);
      this.orderForm.controls['Address'].setValue(order.Address);
      this.orderForm.controls['City'].setValue(order.City);
      this.orderForm.controls['Country'].setValue(order.Country);
      this.ShipperId = order.ShipVia;
    });
  }

  CreateOrder(order: Order) {
    if (this.orderIdUpdate == null) {
      this.orderService.createOrder(order).subscribe(
        () => {
          this.dataSaved = true;
          this.SavedSuccessful(1);
          this.LoadAllOrders();
          this.orderIdUpdate = null;
          this.orderForm.reset();
        }
      );
    } else {
      order.Id = this.orderIdUpdate;      

      this.orderService.updateOrder(order).subscribe(() => {
        this.dataSaved = true;
        this.SavedSuccessful(0);
        this.LoadAllOrders();
        this.orderIdUpdate = null;
        this.orderForm.reset();
      });
    }
  }

  DeleteOrder(Id: number) {
    if (confirm("¿DESEA ELIMINAR LA SIGUIENTE ORDEN?")) {
      this.orderService.deleteOrderById(Id).subscribe(() => {
        this.dataSaved = true;
        this.SavedSuccessful(2);
        this.LoadAllOrders();
        this.orderIdUpdate = null;
        this.orderForm.reset();
      });
    }
  }

  FillShippersDDL() {
    this.allShippers = this.orderService.getShippers();
  }  

  resetForm() {
    this.orderForm.reset();
    this.message = null;
    this.dataSaved = false;
    this.LoadAllOrders();
  }

  SavedSuccessful(isUpdate: number) {
    if (isUpdate == 0) {
      this._snackBar.open('ORDEN ACTUALIZADA EXITOSAMENTE', 'CERRAR', {
        duration: 2000,
        horizontalPosition: this.horizontalPosition,
        verticalPosition: this.verticalPosition,
      });
    }
    else if (isUpdate == 1) {
      this._snackBar.open('ORDEN CARGADA EXITOSAMENTE', 'CERRAR', {
        duration: 2000,
        horizontalPosition: this.horizontalPosition,
        verticalPosition: this.verticalPosition,
      });
    }
    else if (isUpdate == 2) {
      this._snackBar.open('ORDEN ELIMINADA EXITOSAMENTE', 'CERRAR', {
        duration: 2000,
        horizontalPosition: this.horizontalPosition,
        verticalPosition: this.verticalPosition,
      });
    }
  }

  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
}
