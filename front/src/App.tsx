import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import './App.css';
import { NamedTupleMember } from 'typescript';
import { Product } from './models/ProductModel';




async function getProduct() : Promise<Product> {
  debugger
  const response = await fetch ('https://localhost:7123/Product/0', {
    mode: 'no-cors'
  });
  return await response.json();
  
}

function App() {

  const [product1, setProduct1] = useState<Product | null>(null);
  useEffect(() => {
    const initialize = async () => {
      const loadedProduct1 = await getProduct();
      setProduct1(loadedProduct1);
    }
    initialize();
  }, [])

  return (
    <div className="App">
     <div> {product1?.name} {product1?.price}</div>
    </div>
  );
}

export default App;
