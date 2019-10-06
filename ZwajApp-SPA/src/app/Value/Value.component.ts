import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { error } from '@angular/compiler/src/util';

@Component({
  selector: 'app-Value',
  templateUrl: './Value.component.html',
  styleUrls: ['./Value.component.css']
})
export class ValueComponent implements OnInit {
Values:any;
  constructor( private Http: HttpClient) { }

  ngOnInit() {
    this.GetValues();
  }
  GetValues() {
    this.Http.get("http://localhost:5000/api/values").subscribe(Response => {this.Values = Response; } ,
    error => {console.log(error); }
    )
  }

}
