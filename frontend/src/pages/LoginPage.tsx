import Main from "../layouts/Main";
import Drawer from "../components/organisms/Drawer";
import User from "../layouts/User";

function LoginPage() {
  return (
    <Main>
      <Drawer>
        <User />
      </Drawer>
    </Main>
  );
}

export default LoginPage;
