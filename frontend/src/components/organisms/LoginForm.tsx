import { ErrorMessage, Field, Form, Formik } from 'formik';
import { useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import * as Yup from 'yup';
import { login } from '../../api/authentication';
import { getClaims, saveTokenInLocalStorage } from '../../api/handlerJWT';
import { authenticationResponse, userCredentials } from '../../models/auth.model';
import { authenticationStore } from '../../stores/authenticationStore';
import ButtonLogin from "../atoms/ButtonLogin";

function LoginForm() {
  const { credentials, setCredencials, setIsAuthenticated } = authenticationStore();
  const navigate = useNavigate();

  const initialValues: userCredentials = {
    userName: '',
    password: '',
  };

  const validationSchema = Yup.object().shape({
    userName: Yup.string().email('Email inválido.').required('Email es requerido.'),
    password: Yup.string().required('Password es requerido.'),
  });

  useEffect(() => {
    if (Array.isArray(credentials) && credentials.length > 0) {
      navigate("/home");
    }
  }, [credentials, navigate]);

  const handleSubmit = async (values: userCredentials) => {
    try {
      const response = await login(values);
      saveTokenInLocalStorage(response as authenticationResponse);
      setCredencials(getClaims());
      setIsAuthenticated(true);
    } catch (error) {
      console.error(error);
    }
  };

  return (
    <Formik
      initialValues={initialValues}
      validationSchema={validationSchema}
      onSubmit={handleSubmit}
    >
      {({ isSubmitting }) => (
        <Form>
          <div className="hero h-full bg-base-100">
            <div className="hero-content flex-col lg:flex-row-reverse">
              <div className="card flex-shrink-0 w-full max-w-sm shadow-2xl bg-base-100">
                <div className="card-body">
                  <div className="form-control">
                    <label className="label">
                      <span className="label-text">Email</span>
                    </label>
                    <Field type="text" name="userName" className="input input-bordered" />
                    <ErrorMessage name="userName" component="div" />
                  </div>
                  <div className="form-control">
                    <label className="label">
                      <span className="label-text">Password</span>
                    </label>
                    <Field type="password" name="password" className="input input-bordered" />
                    <ErrorMessage name="password" component="div" />
                    <label className="label">
                      <a href="#" className="label-text-alt link link-hover">
                        Forgot password?
                      </a>
                    </label>
                  </div>

                  <div className="form-control mt-6">
                    <ButtonLogin
                      type="submit"
                      placeholder="Iniciar Sesión"
                      disabled={isSubmitting}
                    />
                  </div>
                </div>
              </div>
            </div>
          </div>
        </Form>
      )}
    </Formik>
  );
}

export default LoginForm;
