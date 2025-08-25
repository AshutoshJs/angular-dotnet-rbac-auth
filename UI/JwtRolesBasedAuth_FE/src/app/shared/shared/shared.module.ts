import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { PipesModule } from '../pipes/pipes.module';


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
        RouterModule,
        FormsModule,
        ReactiveFormsModule,
        PipesModule
  ],
    exports: [
        CommonModule,
        RouterModule,
        FormsModule,
        ReactiveFormsModule,
        PipesModule
    ]
})
export class SharedModule { }
