import  {useEffect} from 'react';


//Simple hook demos how to export the logic of two child components in a single hook
export function useCustomHook(count: Number) {
    useEffect(() => {
        document.title = `Count ${count}`;
    }, [count]);
}
