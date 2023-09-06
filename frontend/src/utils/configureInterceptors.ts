import axios from "axios";
import { getAccessToken } from "../api/handlerJWT";

export const configureInterceptor = () => {
  axios.interceptors.request.use(
    function (config) {
      const token = getAccessToken();
      if (token) {
        config.headers.Authorization = `bearer ${token}`;
      }
      return config;
    },
    function (error) {
      return Promise.reject(error);
    }
  );
};
