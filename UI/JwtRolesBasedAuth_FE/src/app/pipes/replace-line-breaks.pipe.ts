import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'replaceLineBreaks'
})
export class ReplaceLineBreaksPipe implements PipeTransform {

  // transform(value: unknown, ...args: unknown[]): unknown {
  //   return null;
  // }
transform(value:string): string {
  return value && this.isString(value) ? value.replace(/_/g,'_<wbr>'): value;
}
isString = (value: any) => { if (typeof value === 'string' || value instanceof String) { return true; } else return false };
}
