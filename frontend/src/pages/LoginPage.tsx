import LoginForm from "../components/organisms/LoginForm"
import Main from "../layouts/Main"
import Drawer from "../components/organisms/Drawer"

function LoginPage() {
    return (
       
            <Main>
                 <Drawer>
                    <LoginForm />
                 </Drawer>
             </Main>
      
    )
}

export default LoginPage