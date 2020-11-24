import { Component, OnInit } from '@angular/core';
import { Attack } from '../../../shared/attack';

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent implements OnInit {

  constructor() { }

  attacks : Attack[] = [
    {id:1 , message: 'stp'},
    {id:2 , message: 'udp'},
    {id:3 , message: 'mitm'},
  ];

  ngOnInit(): void {
  }

}
