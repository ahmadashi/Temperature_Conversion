import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  MatTabsModule, MatSidenavModule, MatToolbarModule, MatIconModule, MatButtonModule, MatListModule, MatMenuModule, MatCardModule, MatPaginatorModule, MatTableModule, MatDividerModule,
  MatFormFieldModule, MatInputModule, MatOptionModule, MatSelectModule, MatProgressSpinnerModule
} from '@angular/material';

@NgModule({
  imports: [
    MatMenuModule,
    MatListModule,
    MatButtonModule,
    MatIconModule,
    MatToolbarModule,
    CommonModule,
    MatTabsModule,
    MatSidenavModule,
    MatCardModule,
    MatPaginatorModule,
    MatTableModule,
    MatSidenavModule,
    MatDividerModule,
    MatFormFieldModule,
    MatInputModule,
    MatOptionModule,
    MatSelectModule,
    MatProgressSpinnerModule
  ],
  exports: [
    MatMenuModule,
    MatListModule,
    MatButtonModule,
    MatIconModule,
    MatToolbarModule,
    MatTabsModule,
    MatSidenavModule,
    MatCardModule,
    MatPaginatorModule,
    MatTableModule,
    MatSidenavModule,
    MatDividerModule,
    MatFormFieldModule,
    MatInputModule,
    MatOptionModule,
    MatSelectModule,
    MatProgressSpinnerModule
  ],
  declarations: []
})
export class MaterialModule { }
