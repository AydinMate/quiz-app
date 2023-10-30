<script lang="ts">
	import { goto } from '$app/navigation';
	import user from '../../user';

	const logout = () => {
		user.update((val) => (val = null));
		goto("/")
	};
</script>

<div class="flex flex-col items-center h-[100vh] space-y-4">
	<h1 class="h1 mt-[2rem]">Dashboard</h1>
	<div class="space-x-8">
		<button on:click={() => goto('/quiz')} class="btn variant-filled">Start Quiz</button>
		<button on:click={logout} class="btn variant-filled">Logout</button>
	</div>
</div>
