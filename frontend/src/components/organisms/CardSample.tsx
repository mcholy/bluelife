function CardSample() {
    return (
        <div className="card w-96 bg-base-100 shadow-xl">
            <figure><img src="https://www.streamingguide.net/wp-content/uploads/dota-2-300x400.jpg" alt="Shoes" /></figure>
            <div className="card-body">
                <h2 className="card-title">Shoes!</h2>
                <p>If a dog chews shoes whose shoes does he choose?</p>
                <div className="card-actions justify-end">
                    <button className="btn btn-primary">Buy Now</button>
                </div>
            </div>
        </div>
    )
}

export default CardSample