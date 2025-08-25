import { DataType } from "../../../cores/constants/data-types";
import { SortDirectionEnum } from "../../../cores/constants/sort-direction.enum";

export interface Column {
    type: DataType;
    name: string;
    label: string;
    filter?: boolean;
    sortable?: boolean;
    sort?: SortDirectionEnum;
    visible?: boolean;
    hidden?: boolean;
    filterApplied?: boolean;
    permissions?: Array<string>;
}
