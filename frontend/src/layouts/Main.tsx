import Footer from "../components/organisms/Footer";
import NavBar from "../components/organisms/NavBar";
export default function Main({ children }: mainProps) {
    return (
        <>
            <NavBar />
            {children}
            <Footer />
        </>
    );
}

interface mainProps {
    children: React.ReactNode;
}