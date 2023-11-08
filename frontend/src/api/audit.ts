import {
  auditDto,
  auditForCreationDto,
  auditResponse,
} from "../models/audit.model";
import axiosWithHeaders from "../utils/axiosWithHeaders";
import { urlAudit } from "../utils/endpoints";

export async function createAudit(audit: auditForCreationDto) {
  try {
    const response = await axiosWithHeaders.post<auditDto>(
      `${urlAudit}`,
      audit
    );
    return response.data;
  } catch (error) {
    console.error("Error:", error);
  }
}

export async function getAudit(id: string) {
  try {
    const response = await axiosWithHeaders.get<auditDto>(`${urlAudit}/${id}`);
    return response.data;
  } catch (error) {
    console.error("Error:", error);
  }
}

export async function getAllAudits() {
  try {
    const response = await axiosWithHeaders.get<auditResponse>(`${urlAudit}`);
    return response.data;
  } catch (error) {
    console.error("Error:", error);
  }
}
