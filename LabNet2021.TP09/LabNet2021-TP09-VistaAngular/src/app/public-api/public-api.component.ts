import { Component, OnInit, ViewChild } from '@angular/core';

import { PublicApi } from '../models/public-api';
import { PublicApiService } from '../services/public-api.service';

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
