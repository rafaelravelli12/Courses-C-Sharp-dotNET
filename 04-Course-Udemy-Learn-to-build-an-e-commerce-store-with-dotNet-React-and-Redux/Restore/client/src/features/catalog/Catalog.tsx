import agent from '../../app/api/agent';
import { Product } from '../../app/models/product';
import ProductList from './ProductList';
import { useEffect, useState } from 'react';

export default function Catalog() {

    const [products, setProducts] = useState<Product[]>([]);

    //useEffect(() => {
    //    fetch('http://localhost:5000/api/products')
    //        .then(response => response.json())
    //        .then(data => setProducts(data));
    //}, [])

    useEffect(() => {
        agent.Catalog.list().then(products => setProducts(products))
    }, [])

    return (
        <>
            <ProductList products={products} />
        </>
    )
}
