export class Employee {
  businessEntityID: number;
  nationalIDNumber: string;
  loginID: string;
  organizationLevel: number;
  jobTitle: string;
  birthDate: Date;
  maritalStatus: string;
  gender: string;
  hireDate: Date;
  salariedFlag: boolean;
  vacationHours: number;
  sickLeaveHours: number;
  currentFlag: boolean;
  rowGuid: string;
  modifiedDate: Date;

  constructor(data: any) {
    this.businessEntityID = data.businessEntityID;
    this.nationalIDNumber = data.nationalIDNumber;
    this.loginID = data.loginID;
    this.organizationLevel = data.organizationLevel;
    this.jobTitle = data.jobTitle;
    this.birthDate = new Date(data.birthDate);
    this.maritalStatus = data.maritalStatus;
    this.gender = data.gender;
    this.hireDate = new Date(data.hireDate);
    this.salariedFlag = data.salariedFlag;
    this.vacationHours = data.vacationHours;
    this.sickLeaveHours = data.sickLeaveHours;
    this.currentFlag = data.currentFlag;
    this.rowGuid = data.rowGuid;
    this.modifiedDate = new Date(data.modifiedDate);
  }
}
