import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '../shared/shared.module';


import { RouterModule } from '@angular/router';

import { TableModule } from 'primeng/table';
import { MultiSelectModule } from 'primeng/multiselect';
import { ContextMenuModule } from 'primeng/contextmenu';
import { DialogModule } from 'primeng/dialog';
import { ButtonModule } from 'primeng/button';
import { DropdownModule } from 'primeng/dropdown';
import { CheckboxModule } from 'primeng/checkbox';
import { ProgressBarModule } from 'primeng/progressbar';
import { InputTextModule } from 'primeng/inputtext';
import { ToastModule } from 'primeng/toast';
import { SliderModule } from 'primeng/slider';
import { FieldsetModule } from 'primeng/fieldset';
import { TooltipModule } from 'primeng/tooltip';
import {CalendarModule} from 'primeng/calendar';
import { TagModule } from 'primeng/tag';
import { SelectModule } from 'primeng/select';
import { ConfirmDialog } from 'primeng/confirmdialog';
import { AvatarModule } from 'primeng/avatar';

@NgModule({
  declarations: [],
  imports: [
    SharedModule,
     RouterModule,
        TableModule,
        FieldsetModule,
        ToastModule,
        SliderModule,
        MultiSelectModule,
        ContextMenuModule,
        DialogModule,
        ButtonModule,
        DropdownModule,
        ProgressBarModule,
        CheckboxModule,
        InputTextModule,
        TooltipModule,
        CalendarModule,
        TagModule,
        SelectModule,
        ConfirmDialog,
        AvatarModule
  ],
  exports: [
    SharedModule,
        RouterModule,
        TableModule,
        FieldsetModule,
        ToastModule,
        SliderModule,
        MultiSelectModule,
        ContextMenuModule,
        DialogModule,
        ButtonModule,
        DropdownModule,
        ProgressBarModule,
        CheckboxModule,
        InputTextModule,
        TooltipModule,
        CalendarModule,
        TagModule,
        SelectModule,
        ConfirmDialog,
        AvatarModule
    ]
})
export class PrimeComponentModule { }
