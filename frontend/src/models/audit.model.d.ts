export interface auditForCreationDto {
  userName: string;
  companyName: string;
  details: string;
}

export interface auditDto {
  Id: string;
  userName: string;
  companyName: string;
  details: string;
  dateEntry: Date;
}

export interface auditResponse {
  audits: auditDto[];
}
