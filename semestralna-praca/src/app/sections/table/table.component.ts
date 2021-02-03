import { Component, OnInit } from '@angular/core';
import { Attack } from 'src/shared/attack';
import {TableService} from '../../services/table.service'

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent implements OnInit {

  attacks: Attack[] = [];

  constructor(private tableData: TableService) {
   }
  

  ngOnInit(): void {
  this.getAttacks();
  }
  
  
  getAttacks(): void {
    this.tableData.getAttacks().subscribe(attacks => {
      this.attacks = attacks;
    })
  };
  
}
  
