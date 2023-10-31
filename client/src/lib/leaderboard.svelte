<script lang="ts">
	export let leaderboard: LeaderboardUser[];
</script>

<div>
	<div class="grid grid-cols-3 text-center font-bold h3">
		<h3>Username</h3>
		<h3>Correct Answers</h3>
		<h3>Number of Attempts</h3>
	</div>
	{#each leaderboard as leaderboardUser}
		<div class="grid grid-cols-3 text-center h4 space-y-2 mt-2">
			<h4>{leaderboardUser.username}</h4>
			<h4>{leaderboardUser.correctAnswers}</h4>
			<h4>{leaderboardUser.attempts}</h4>
		</div>{/each}
</div>
