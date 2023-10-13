const apiURL = import.meta.env.VITE_APP_API_URL;
const apiURLPersona = import.meta.env.VITE_APP_API_PERSONA_URL;

export const urlAuth = `${apiURL}/authentication`;
export const urlToken = `${apiURL}/token`;
export const urlPersonaInfo = `${apiURLPersona}/BuscarDocumentoAndroid`;
export const urlAudit = `${apiURL}/audits`;
