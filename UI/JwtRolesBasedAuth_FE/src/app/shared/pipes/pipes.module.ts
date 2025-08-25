import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReplaceLineBreaksPipe } from '../../pipes/replace-line-breaks.pipe';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    ReplaceLineBreaksPipe
  ],
	exports: [
		ReplaceLineBreaksPipe
	]
})
export class PipesModule { }
