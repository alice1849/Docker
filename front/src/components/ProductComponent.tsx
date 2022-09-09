import { Product } from '../models/ProductModel';
import {useEffect, useState} from 'react';

type ProductProps = {
    product: Product | null,
};
const ProductComponent = (props: ProductProps) =>
{  
    const [product1, setProduct1] = useState<Product | null>(null);
    useEffect( () => {
        setProduct1(props.product);
    }, [])

    const result: JSX.Element = props.product !== null
    ? (<div>Product: {props.product.name} Price: {props.product.price}</div>)
    : (<div>No content</div>)

    return(
        <div>
          {result}
        </div>
    ) 
}
export default ProductComponent