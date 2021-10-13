import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

import { Observable } from 'rxjs';

import { MatSnackBar, MatSnackBarHorizontalPosition, MatSnackBarVerticalPosition } from '@angular/material/snack-bar';
import { MatDialog } from '@angular/material/dialog';
import { MatTableDataSource, } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';

import { SelectionModel } from '@angular/cdk/collections';

import { PublicApi } from '../public-api';
import { PublicApiService } from '../public-api.service';

@Component({
  selector: 'app-public-api',
  templateUrl: './public-api.component.html',
  styleUrls: ['./public-api.component.css']
})

export class PublicApiComponent implements OnInit {

  dataSource!: PublicApi[];

  constructor(private publicApiService: PublicApiService) { 
    this.dataSource = [];    
  }

  ngOnInit(): void {
    this.LoadApi();    
  }

  LoadApi() {
    this.publicApiService.getAllQuotes().subscribe((dataSource: PublicApi[]) => {
      this.dataSource = dataSource; 
    });
  }

  resetForm() {
    this.LoadApi();
  }
}
