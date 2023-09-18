import { useRouteError } from "react-router-dom";

export default function ErrorPage() {
    const error = useRouteError() as propsErrorPage;
    console.error(error);
    return (
        <div id="error-page">
            <h1>Oops!</h1>
            <p>Sorry, an unexpected error has occurred.</p>
            <p>
                <i>{error.statusText || error.message}</i>
            </p>
        </div>
    );
}

interface propsErrorPage {
    message: string;
    statusText: string;
}