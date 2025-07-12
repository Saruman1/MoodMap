import { render, screen } from '@testing-library/react';
import App from './App';

test('renders Home heading', () => {
    render(<App />);
    const heading = screen.getByRole('heading', { name: /Home/i });
    expect(heading).toBeInTheDocument();
});