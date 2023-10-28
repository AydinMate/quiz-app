import { redirect } from '@sveltejs/kit';

export const load = async (questionNumber: number) => {
	if (questionNumber > 2) {
		throw redirect(302, '/results');
	}
};
