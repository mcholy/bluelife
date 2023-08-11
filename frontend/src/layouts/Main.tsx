import Footer from "../components/organisms/Footer";
import NavBar from "../components/organisms/NavBar";

export default function Main({ children }: mainProps) {
  return (
    <section className="flex flex-col h-screen">
      <NavBar title="BluLife" />
      {children}
      <Footer />
    </section>
  );
}

interface mainProps {
  children: React.ReactNode;
}
